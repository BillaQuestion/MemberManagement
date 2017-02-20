using DevExpress.XtraEditors;
using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MM.UI
{
    public partial class FrmOneTimeExperience : Form
    {
        OneTimeExperience _product;

        public OneTimeExperience Product { get { return _product; } }

        public FrmOneTimeExperience()
        {
            InitializeComponent();
            _product = new OneTimeExperience();
        }

        public FrmOneTimeExperience(OneTimeExperience product)
        {
            InitializeComponent();
            _product = product;
        }

        private void FrmTimesCard_Load(object sender, EventArgs e)
        {
            var mediums = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>().GetAll();
            bindingSourceMediums.DataSource = mediums;
            bindingSourceProduct.DataSource = _product;

            txtName.Validated += ValidatedHandler;
            lkuMedium.Validated += ValidatedHandler;
            txtPrice.Validated += ValidatedHandler;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bindingSourceProduct.EndEdit();

            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_product,
                new ValidationContext(_product),
                results);
            if (isValid)
                DialogResult = DialogResult.OK;
            else
            {
                XtraMessageBox.Show("请先完善数据！");
            }
        }

        private void ValidatedHandler(object sender, EventArgs e)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_product,
                new ValidationContext(_product),
                results);

            if (isValid)
            {
                errorProvider.SetError((sender as Control), string.Empty);
                return;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (Binding binding in (sender as Control).DataBindings)
                {
                    sb.Append(string.Join(",", results.Where(o => o.MemberNames.Contains(binding.BindingMemberInfo.BindingField))
                        .Select(o => o.ErrorMessage)));
                }
                errorProvider.SetError((sender as Control), sb.ToString());
            }
        }
    }
}
