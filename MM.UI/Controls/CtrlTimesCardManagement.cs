using DevExpress.XtraEditors;
using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Linq;
using System.Windows.Forms;

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
            if (string.Compare(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv") == 0) return;

            var mediums = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>().GetAll();
            bindingSourceMediums.DataSource = mediums;
            LoadProducts();
        }

        private void LoadProducts()
        {
            IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
            bindingSourceProducts.DataSource = productMgr.GetAll().OfType<TimesCard>();
            //bindingSourceProducts.DataSource = productMgr.GetAll().OfType<T>();
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTimesCard form = new FrmTimesCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                TimesCard product = form.Product;
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                productMgr.Save(product);
                XtraMessageBox.Show("成功地新建了次卡产品！");
                LoadProducts();

            }
        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TimesCard product = gridViewProducts.GetFocusedRow() as TimesCard;
            if (product == null)
            {
                XtraMessageBox.Show("请先选择待修改的产品！", "提示");
                return;
            }

            FrmTimesCard form = new FrmTimesCard(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                product = form.Product;
                productMgr.Save(product);
                XtraMessageBox.Show("成功地修改了次卡产品！");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TimesCard product = gridViewProducts.GetFocusedRow() as TimesCard;
            if (product == null)
            {
                XtraMessageBox.Show("请先选择待删除的次卡产品！", "提示");
                return;
            }

            DialogResult result = XtraMessageBox.Show(string.Format("确认删除次卡[{0}]吗？", product.Name),
                "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                productMgr.Delete(product.Id);
                LoadProducts();
                XtraMessageBox.Show("删除成功！");
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadProducts();
        }
    }
}
