using DevExpress.XtraEditors;
using MM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM.UI
{
    public partial class FrmMedium : Form
    {
        Medium _medium;
        public Medium Medium { get { return _medium; } }

        public FrmMedium()
        {
            InitializeComponent();
            _medium = new Medium();
        }

        public FrmMedium(Medium medium)
        {
            InitializeComponent();
            _medium = medium;
        }

        private void FrmMedium_Load(object sender, EventArgs e)
        {
            bindingSourceMedium.DataSource = _medium;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bindingSourceMedium.EndEdit();

            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_medium,
                new ValidationContext(_medium),
                results);
            if (isValid)
                DialogResult = DialogResult.OK;
            else
            {
                XtraMessageBox.Show("请先完善数据！");
            }
        }

        private void ValidatedHandler(object sender, EventArgs e)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_medium,
                new ValidationContext(_medium),
                results);

            if (isValid)
            {
                errorProvider.SetError((sender as Control), string.Empty);
                return;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (Binding binding in (sender as Control).DataBindings)
                {
                    sb.Append(string.Join(",", results.Where(o => o.MemberNames.Contains(binding.BindingMemberInfo.BindingField))
                        .Select(o => o.ErrorMessage)));
                }
                errorProvider.SetError((sender as Control), sb.ToString());
            }
        }
    }
}
