using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
                foreach (var result in results)
                {
                    if (result.MemberNames.Contains("Name"))
                    {
                        errorProvider.SetError(txtName, result.ErrorMessage);
                    }
                    if (result.MemberNames.Contains("Medium") || result.MemberNames.Contains("MediumId"))
                    {
                        errorProvider.SetError(lkuMedium, result.ErrorMessage);
                    }
                }
            }
        }
    }
}
