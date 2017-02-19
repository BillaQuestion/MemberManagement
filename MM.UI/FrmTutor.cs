using DevExpress.XtraEditors;
using MM.Model;
using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Linq;

namespace MM.UI
{
    public partial class FrmTutor : Form
    {
        /// <summary>
        /// 当前在编辑的教师对象
        /// </summary>
        Tutor _tutor;
        public Tutor Tutor { get { return _tutor; } }

        public FrmTutor()
        {
            InitializeComponent();
            _tutor = new Tutor();
        }

        public FrmTutor(Tutor tutor)
        {
            InitializeComponent();
            _tutor = tutor;
        }

        private void FrmTutor_Load(object sender, EventArgs e)
        {
            lkuGender.Properties.DataSource = Enum.GetValues(typeof(Gender));
            bindingSourceTutor.DataSource = _tutor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bindingSourceTutor.EndEdit();

            //if (string.IsNullOrWhiteSpace(_tutor.Name))
            //{
            //    XtraMessageBox.Show("请输入教师姓名！", "提示");
            //    return;
            //}

            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_tutor,
                new ValidationContext(_tutor),
                results);
            if (isValid)
                DialogResult = DialogResult.OK;
            else
            {
                foreach (var result in results)
                {
                    if (result.MemberNames.Contains("Name"))
                    {
                        errorProvider.SetError(txtName, result.ErrorMessage);
                    }
                }
            }
        }
    }
}
