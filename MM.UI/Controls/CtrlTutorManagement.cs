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

        }

        private void bbiModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
