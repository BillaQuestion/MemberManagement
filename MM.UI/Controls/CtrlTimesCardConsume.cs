using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MM.Business;
using MM.Model;

namespace MM.UI.Controls
{
    public partial class CtrlTimesCardConsume : UserControl
    {
        IMemberMgr _memberMgr;

        public CtrlTimesCardConsume(IMemberMgr memberMgr)
        {
            InitializeComponent();
            _memberMgr = memberMgr;
        }

        private void btnPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnConsume_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                XtraMessageBox.Show("请先输入顾客的手机号码！");
                txtPhoneNumber.Focus();
                return;
            }

            string phoneNumber = txtPhoneNumber.Text.Trim();
            Member member = _memberMgr.GetByPhoneNumber(phoneNumber);
            if (member == null)
            {
                XtraMessageBox.Show(string.Format("系统中不存在手机号码为“{0}”的顾客！", phoneNumber),
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bindingSourceMemberCard.DataSource = member.MemberCards.OfType<TimesCardMemberCard>();
            }
        }

        private void grdViewMemberCard_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                //var comsumptions = 
            }
        }
    }
}
