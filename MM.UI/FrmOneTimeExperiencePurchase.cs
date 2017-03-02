using MM.Business;
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
using MM.Model;
using DevExpress.XtraEditors;
using System.Threading;

namespace MM.UI
{
    public partial class FrmOneTimeExperiencePurchase : Form
    {
        public FrmOneTimeExperiencePurchase()
        {
            InitializeComponent();
        }

        private void FrmTimesCardPurchase_Load(object sender, EventArgs e)
        {
            IMediumMgr mediumMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>();
            bindingSourceMediums.DataSource  = mediumMgr.GetAll().ToList();

            IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
            bindingSourceProducts.DataSource = productMgr.GetAll().OfType<OneTimeExperience>();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isValidated = true;
            if (string.IsNullOrEmpty(lkuProduct.Text))
            {
                errorProvider.SetError(lkuProduct, "产品不能为空!");
                isValidated = false;
            }
            else
                errorProvider.SetError(lkuProduct, "");
            if (!isValidated) return;

            try
            {
                string tutorName = Thread.CurrentPrincipal.Identity.Name;
                Guid productId = Guid.Parse(lkuProduct.EditValue.ToString());
                IStudioService studioService = new ContainerBootstrapper().ChildContainer.Resolve<IStudioService>();
                studioService.Sell(tutorName, productId);
                XtraMessageBox.Show("成功！");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("购买时出现错误：" + ex.Message, "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lkuProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lkuProduct.Text)) return;

            IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
            var product = productMgr.GetById(Guid.Parse(lkuProduct.EditValue.ToString()));
            if (product != null)
            {
                lkuMedium.EditValue = product.MediumId;
                txtPrice.Text = product.Price.ToString("0.00");
            }
        }
    }
}
