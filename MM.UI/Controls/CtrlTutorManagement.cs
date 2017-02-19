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
using Microsoft.Practices.Unity;
using MM.Business;
using DevExpress.XtraEditors;

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
            _tutors = new ContainerBootstrapper().ChildContainer.Resolve<IAdministrator>()
                .GetAllTutors().ToList();
            bindingSourceTutors.DataSource = _tutors;
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTutor form = new FrmTutor();
            if (form.ShowDialog() == DialogResult.OK)
            {
                IAdministrator admin = new ContainerBootstrapper().ChildContainer.Resolve<IAdministrator>();
                Tutor tutor = form.Tutor;
                admin.CreateTutor(tutor.Name, tutor.Gender, tutor.PhoneNumber, tutor.Address, tutor.IsManager);
                XtraMessageBox.Show("成功地新建国教师用户！\n\n默认密码为\"password\"");
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
                IAdministrator admin = new ContainerBootstrapper().ChildContainer.Resolve<IAdministrator>();
                tutor = form.Tutor;
                admin.ModifyTutor(tutor);
                XtraMessageBox.Show("成功地修改了教师用户！");
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
