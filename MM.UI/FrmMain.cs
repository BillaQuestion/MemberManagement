//---------------------------------------------------------------------
// 框架主窗口基类
// 作者：张忠民
// 创建时间：
//
// 修改时间：2011年1月25日
// 修改人：张忠民
// 修改原因：修改状态栏的显示位置，修改登录窗体的调用位置
//
// 修改时间：年-月-日
// 修改人：
// 修改原因：
//
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace MM.UI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 标志是否是注销操作,如果是注销,关闭窗体时不弹出对话框
        /// </summary>
        protected bool isLogOut = false;

        /// <summary>
        /// //启动“帮助”窗体的进程
        /// </summary>
        protected System.Diagnostics.Process helpProcess;

        /// <summary>
        /// 状态栏欢迎信息
        /// </summary>
        public string ToolTips { get; set; }

        /// <summary>
        /// 状态栏版权信息
        /// </summary>
        public string CopyRight { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.BonusSkins.Register();
        }

        /// <summary>
        /// “导航”按钮点击事件处理程序
        /// </summary>
        protected virtual void 导航()
        {
            //打开功能导航窗
            //OpenInputWindow("00000001-0000-0000-0000-000000000001");
        }

        /// <summary>
        /// “帮助主题”菜单按钮点击事件处理程序
        /// </summary>
        protected virtual void 帮助主题()
        {
            try
            {
                string helpFile = Application.StartupPath + "\\帮助.CHM";
                helpProcess = System.Diagnostics.Process.Start(helpFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// “关于本系统”菜单按钮点击事件处理程序
        /// </summary>
        protected virtual void 关于()
        {

        }

        /// <summary>
        /// “注销”菜单按钮点击事件处理程序
        /// </summary>
        protected virtual void 注销()
        {
            if (MessageBox.Show("您真的要注销当前用户吗？", "注销用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                isLogOut = true;
                Application.Restart();
            }
        }

        /// <summary>
        /// 获取皮肤信息
        /// </summary>
        protected virtual void GetSkinInfo()
        {
            string skin = string.Empty;
            try
            {
                skin = ConfigurationManager.AppSettings["Skin"].Trim();
            }
            catch
            {
                skin = "Caramel";
            }

            if (skin != "")
            {
                defaultLookAndFeel.LookAndFeel.SkinName = skin;
                switch (skin)
                {
                    case "Caramel":
                        bbiRed.Down = true;
                        break;
                    case "Black":
                        bbiBlack.Down = true;
                        break;
                    case "Blue":
                        bbiBlue2.Down = true;
                        break;
                    case "Lilian":
                        bbiPurple.Down = true;
                        break;
                    case "iMaginary":
                        bbiBlue1.Down = true;
                        break;
                    case "Coffee":
                        bbiCoffee.Down = true;
                        break;
                    case "Summer 2008":
                        bbiSummer.Down = true;
                        break;
                    case "Valentine":
                        bbiValentine.Down = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                defaultLookAndFeel.LookAndFeel.SkinName = "Caramel";
                bbiRed.Down = true;
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ////
            //// 验证用户密码
            //// 
            //if (!ValidateLoginName())
            //{
            //    return;
            //}

            //if (string.Compare(System.Diagnostics.Process.GetCurrentProcess().ProcessName, "devenv") != 0)
            //{
            //    //
            //    // 设置主窗体状态栏
            //    //
            //    this.bsiLoginTime.Caption =
            //        string.Format("登录时间：{0:yyyy-MM-dd HH:mm}", DateTime.Now);
            //    this.bsi当前用户.Caption = string.Format("用户：{0}", this.GetUserRealName());
            //    this.bsiToolTips.Caption = ToolTips;
            //    this.bsiCopyright.Caption = CopyRight;
            //    this.GetSkinInfo();

            //    // 打开功能导航窗
            //    this.导航();
            //}

            FrmNavigator frmNavigator = new FrmNavigator();
            frmNavigator.MdiParent = this;
            frmNavigator.Show();
            // 窗体最大化显示
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 打开登录窗口，验证用户登录密码
        /// </summary>
        /// <returns>如果验证通过，返回true；否则，返回false。</returns>
        protected virtual bool ValidateLoginName()
        {
            return true;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 打开导航窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExplore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.导航();
        }

        /// <summary>
        /// 关于本系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.关于();
        }

        /// <summary>
        /// 帮助主题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiHelpContent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.帮助主题();
        }

        private void bbi导入配置_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.DefaultExt = ".config";
            openFileDialog.Filter = "应用系统配置文件(*.config)|*.config|所有文件(*.*)|*.*";
            openFileDialog.Title = "请选择应用系统配置文件";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string configurationFile = openFileDialog.FileName;

                //TODO:修改
                //new ModuleConfigurationHelper().Import(configurationFile);

                MessageBox.Show("导入成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 注销当前用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.注销();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiModifyPwd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.修改密码();
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        protected virtual void 修改密码()
        {
            //Form form = new Dayi.Security.UI.FormChangeOwnPassword();
            //form.ShowDialog();
        }

        private void ChangeSkin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Tag == null)
            {
                return;
            }
            defaultLookAndFeel.LookAndFeel.SkinName = e.Item.Tag.ToString().Trim();
            Configuration configuration = null;    //Configuration对象
            AppSettingsSection appSection = null;  //AppSection对象
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //取得AppSetting节
            appSection = configuration.AppSettings;
            //赋值并保存
            appSection.Settings["Skin"].Value = e.Item.Tag.ToString().Trim();
            configuration.Save();
        }

        /// <summary>
        /// 显示/隐藏状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciDisplayStatusbar_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bar3.Visible = this.bciDisplayStatusbar.Checked;
        }

        /// <summary>
        /// 显示/隐藏工具栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciDisplayToolbox_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bar1.Visible = this.bciDisplayToolbox.Checked;
        }

        /// <summary>
        /// 关闭所有窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCloseAllWindows_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int mdiChildrenNum = this.MdiChildren.Length;
            for (int i = 0; i < mdiChildrenNum; i++)
            {
                this.MdiChildren[0].Close();
            }
        }   

        /// <summary>
        /// 获取当前用户的真实姓名
        /// </summary>
        /// <returns></returns>
        protected virtual string GetUserRealName()
        {
            string realName = string.Empty;
            try
            {
                //realName = new Dayi.Security.SecuritySystem().GetCurrentUserRealName();
            }
            catch
            {
            }
            return realName;
        }      
    }
}