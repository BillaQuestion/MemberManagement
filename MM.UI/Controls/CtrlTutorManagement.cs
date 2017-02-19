using DevExpress.XtraEditors;
using Microsoft.Practices.Unity;
using MM.Business;
using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MM.UI.Controls
{
    public partial class CtrlTutorManagement : UserControl
    {
        /// <summary>
        /// 系统中的所有教师
        /// </summary>
        List<Tutor> _tutors;

        public CtrlTutorManagement()
        {
            InitializeComponent();
            _tutors = new List<Tutor>();
        }

        private void CtrlTutorManagement_Load(object sender, EventArgs e)
        {
            LoadTutors();
        }

        private void LoadTutors()
        {
            _tutors = new ContainerBootstrapper().ChildContainer.Resolve<ITutorMgr>()
                .GetAll().ToList();
            bindingSourceTutors.DataSource = _tutors;
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTutor form = new FrmTutor();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ITutorMgr tutorMgr = new ContainerBootstrapper().ChildContainer.Resolve<ITutorMgr>();
                Tutor tutor = form.Tutor;
                tutorMgr.Create(tutor.Name, tutor.Gender, tutor.PhoneNumber, tutor.Address, tutor.IsManager);
                XtraMessageBox.Show("成功地新建了教师用户！\n\n默认密码为\"password\"");
                LoadTutors();
            }
        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tutor tutor = gridViewTutors.GetFocusedRow() as Tutor;
            if (tutor == null)
            {
                XtraMessageBox.Show("请先选择待修改的教师！", "提示");
                return;
            }

            FrmTutor form = new FrmTutor(tutor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ITutorMgr tutorMgr = new ContainerBootstrapper().ChildContainer.Resolve<ITutorMgr>();
                tutor = form.Tutor;
                tutorMgr.Modify(tutor);
                XtraMessageBox.Show("成功地修改了教师用户！");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tutor tutor = gridViewTutors.GetFocusedRow() as Tutor;
            if (tutor == null)
            {
                XtraMessageBox.Show("请先选择待删除的教师！", "提示");
                return;
            }

            DialogResult result = XtraMessageBox.Show(string.Format("确认删除教师[{0}]吗？", tutor.Name),
                "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ITutorMgr tutorMgr = new ContainerBootstrapper().ChildContainer.Resolve<ITutorMgr>();
                tutorMgr.Delete(tutor.Id);
                XtraMessageBox.Show("删除成功！");
                LoadTutors();
            }
        }

        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tutor tutor = gridViewTutors.GetFocusedRow() as Tutor;
            if (tutor == null)
            {
                XtraMessageBox.Show("请先选择待重置密码的教师！", "提示");
                return;
            }

            DialogResult result = XtraMessageBox.Show(string.Format("确认重置教师[{0}]的密码吗？", tutor.Name),
                "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ITutorMgr tutorMgr = new ContainerBootstrapper().ChildContainer.Resolve<ITutorMgr>();
                tutorMgr.ResetTutorPassword(tutor.Id);
                XtraMessageBox.Show("重置密码成功！密码重置为\"password\"");
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTutors();
        }
    }
}
