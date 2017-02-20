using DevExpress.XtraEditors;
using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MM.UI.Controls
{
    public partial class CtrlLectureManagement : UserControl
    {
        public CtrlLectureManagement()
        {
            InitializeComponent();
        }

        private void CtrlLectureManagement_Load(object sender, EventArgs e)
        {
            if (string.Compare(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv") == 0) return;

            var mediums = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>().GetAll();
            bindingSourceMediums.DataSource = mediums;
            LoadProducts();
        }

        private void LoadProducts()
        {
            IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
            bindingSourceProducts.DataSource = productMgr.GetAll().OfType<Lecture>();
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLecture form = new FrmLecture();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Lecture product = form.Product;
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                productMgr.Save(product);
                XtraMessageBox.Show("成功地新建了课程产品！");
                LoadProducts();

            }
        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Lecture product = gridViewProducts.GetFocusedRow() as Lecture;
            if (product == null)
            {
                XtraMessageBox.Show("请先选择待修改的产品！", "提示");
                return;
            }

            FrmLecture form = new FrmLecture(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                IProductMgr productMgr = new ContainerBootstrapper().ChildContainer.Resolve<IProductMgr>();
                product = form.Product;
                productMgr.Save(product);
                XtraMessageBox.Show("成功地修改了课程产品！");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Lecture product = gridViewProducts.GetFocusedRow() as Lecture;
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
