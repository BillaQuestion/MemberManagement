using DevExpress.XtraEditors;
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
using MM.Business;

namespace MM.UI
{
    public partial class FrmTutor : Form
    {
        /// <summary>
        /// 当前在编辑的教师对象
        /// </summary>
        Tutor _tutor;

        bool isCreateOperation = true;

        public FrmTutor()
        {
            InitializeComponent();
            _tutor = new Tutor();
        }

        public FrmTutor(Tutor tutor)
        {
            InitializeComponent();
            _tutor = tutor;
         isCreateOperation = false;
        }

        private void FrmTutor_Load(object sender, EventArgs e)
        {
            bindingSourceTutor.DataSource = _tutor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bindingSourceTutor.EndEdit();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                XtraMessageBox.Show("请输入教师姓名！", "提示");
                return;
            }

            IAdministrator admin = new ContainerBootstrapper().ChildContainer.Resolve<IAdministrator>();
            if (isCreateOperation)
            {
                _tutor = admin.CreateTutor(_tutor.Name, _tutor.Gender, _tutor.PhoneNumber, _tutor.Address, _tutor.IsManager);
                XtraMessageBox.Show("成功地新建国教师用户！\n\n默认密码为\"password\"");
                DialogResult = DialogResult.OK;
            }
            else
            {
                admin.ModifyTutor(_tutor);
                XtraMessageBox.Show("成功地修改国教师用户！");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
