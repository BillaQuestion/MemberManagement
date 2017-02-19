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
                    if (result.MemberNames.Contains("Count"))
                    {
                        errorProvider.SetError(txtCount, result.ErrorMessage);
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
