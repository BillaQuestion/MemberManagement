using MM.Business;
using MM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraEditors;

namespace MM.UI
{
    public partial class FrmTimesCard : Form
    {
        TimesCard _product;

        public TimesCard Product { get { return _product; } }

        public FrmTimesCard()
        {
            InitializeComponent();
            _product = new TimesCard();
        }

        public FrmTimesCard(TimesCard product)
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
            txtCount.Validated += ValidatedHandler;
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
