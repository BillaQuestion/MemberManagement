using DevExpress.XtraEditors;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                XtraMessageBox.Show("请先输入用户名！");
                txtUserName.Focus();
                return;
            }

            IAuthenticator userMgr = new ContainerBootstrapper().ChildContainer.Resolve<IAuthenticator>();
            if (userMgr.Authenticate(txtUserName.Text, txtPassword.Text))
                DialogResult = DialogResult.OK;
            else
            {
                XtraMessageBox.Show("用户名或密码不正确！请重新输入！", "提示");
                txtPassword.Focus();
            }
        }
    }
}
