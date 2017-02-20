using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using MM.UI.Controls;
using MM.Model;

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

        private void nbiSell_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void nbiConsume_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void nbiTutor_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            CtrlTutorManagement ctrl = new CtrlTutorManagement();
            pnlMain.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;
        }

        private void nbiTimesCard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            CtrlTimesCardManagement ctrl = new CtrlTimesCardManagement();
            pnlMain.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;
        }

        private void nbiLecture_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            //CtrlLectureManagement ctrl = new CtrlLectureManagement();
            //pnlMain.Controls.Add(ctrl);
            //ctrl.Dock = DockStyle.Fill;
        }

        private void nbiOneTimeExperience_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            //CtrlOneTimeExperienceManagement ctrl = new CtrlOneTimeExperienceManagement();
            //pnlMain.Controls.Add(ctrl);
            //ctrl.Dock = DockStyle.Fill;
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
