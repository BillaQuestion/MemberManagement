using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MM.Model;
using MM.Business;
using Microsoft.Practices.Unity;
using DevExpress.XtraEditors;

namespace MM.UI.Controls
{
    public partial class CtrlTimesCardManagement : UserControl
    {
        public CtrlTimesCardManagement()
        {
            InitializeComponent();
        }

        private void CtrlTimesCardManagement_Load(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
            bindingSourceProducts.DataSource = productMgr.GetAll().OfType<TimesCard>();
        }
        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTimesCard form = new FrmTimesCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                TimesCard product = form.Product;
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                productMgr.AddProduct(product);
                XtraMessageBox.Show("成功地新建了次卡产品！");
                LoadProducts();

            }
        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
