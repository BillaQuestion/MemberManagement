using DevExpress.XtraEditors;
using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MM.UI.Controls
{
    public partial class CtrlMediumManagement : UserControl
    {
        public CtrlMediumManagement()
        {
            InitializeComponent();
        }

        private void CtrlMediumManagement_Load(object sender, EventArgs e)
        {
            if (string.Compare(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv") == 0) return;

            LoadMediums();
        }

        private void LoadMediums()
        {
            IMediumMgr mediumMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>();
            bindingSourceMediums.DataSource = mediumMgr.GetAll();
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMedium form = new FrmMedium();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Medium medium = form.Medium;
                IMediumMgr mediumMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>();
                mediumMgr.Save(medium);
                XtraMessageBox.Show("成功地新建了介质！");
                LoadMediums();

            }
        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medium medium = gridViewProducts.GetFocusedRow() as Medium;
            if (medium == null)
            {
                XtraMessageBox.Show("请先选择待修改的介质！", "提示");
                return;
            }

            FrmMedium form = new FrmMedium(medium);
            if (form.ShowDialog() == DialogResult.OK)
            {
                IMediumMgr mediumMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>();
                medium = form.Medium;
                mediumMgr.Save(medium);
                XtraMessageBox.Show("成功地修改了介质名称！");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medium medium = gridViewProducts.GetFocusedRow() as Medium;
            if (medium == null)
            {
                XtraMessageBox.Show("请先选择待删除的介质！", "提示");
                return;
            }

            DialogResult result = XtraMessageBox.Show(string.Format("确认删除介质[{0}]吗？", medium.Name),
                "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                IMediumMgr mediumMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMediumMgr>();
                mediumMgr.Delete(medium.Id);
                LoadMediums();
                XtraMessageBox.Show("删除成功！");
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadMediums();
        }
    }
}
