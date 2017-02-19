using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using MM.UI.Controls;

namespace MM.UI
{
    public partial class FrmNavigator : DevExpress.XtraEditors.XtraForm
    {
        // 当前控件
        protected UserControl currentCtrl;

        public FrmNavigator()
        {
            InitializeComponent();

            currentCtrl = null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        protected virtual void Item_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
        }

        /// <summary>
        /// 检查Mdi子窗体是否已经打开，如果没有打开，则生成并打开；否则，直接激活它。
        /// </summary>
        /// <param name="frmName"></param>
        /// <returns>如果子窗体已经打开，则返回true；否则，返回false。</returns>
        private bool IsOpened(string formName)
        {
            for (int x = 0; x < this.MdiParent.MdiChildren.Length; x++)
            {
                if (this.MdiParent.MdiChildren[x].Name == formName)
                {
                    this.MdiParent.MdiChildren[x].Activate();
                    return true;
                }
            }
            return false;
        }

        private void nbiSell_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void nbiConsume_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void nbiManagement_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            CtrlTutorManagement ctrl = new CtrlTutorManagement();
            pnlMain.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;
        }

        private void nbiMedium_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void bbi退出系统_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
