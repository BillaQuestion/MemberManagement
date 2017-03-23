namespace MM.UI
{
    partial class FrmLecturePurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            this.bindingSourcePurchase = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkuProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhoneNumber = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceMediums = new System.Windows.Forms.BindingSource(this.components);
            this.lkuMedium = new DevExpress.XtraEditors.LookUpEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.medtDescription = new DevExpress.XtraEditors.MemoEdit();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourcePurchase
            // 
            this.bindingSourcePurchase.DataSource = typeof(MM.Model.SellRecord);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "产  品：";
            // 
            // lkuProduct
            // 
            this.lkuProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProducts, "Id", true));
            this.lkuProduct.Location = new System.Drawing.Point(155, 66);
            this.lkuProduct.Name = "lkuProduct";
            this.lkuProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "产品名称", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Count", "次数", 40, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "价格", 61, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Medium", "Medium", 60, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MediumId", "Medium Id", 123, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lkuProduct.Properties.DataSource = this.bindingSourceProducts;
            this.lkuProduct.Properties.DisplayMember = "Name";
            this.lkuProduct.Properties.NullText = "";
            this.lkuProduct.Properties.ValueMember = "Id";
            this.lkuProduct.Size = new System.Drawing.Size(660, 36);
            this.lkuProduct.TabIndex = 1;
            this.lkuProduct.EditValueChanged += new System.EventHandler(this.lkuProduct_EditValueChanged);
            // 
            // bindingSourceProducts
            // 
            this.bindingSourceProducts.DataSource = typeof(MM.Model.Lecture);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 29);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "次  数：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(302, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 29);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "介  质：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(596, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 29);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "价  格：";
            // 
            // txtCount
            // 
            this.txtCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProducts, "Count", true));
            this.txtCount.Location = new System.Drawing.Point(155, 124);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(125, 36);
            this.txtCount.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(690, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(125, 36);
            this.txtPrice.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 430);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 29);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "顾客姓名：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(407, 430);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(120, 29);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "手机号码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 427);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 36);
            this.txtName.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(533, 427);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(282, 36);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(453, 509);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 509);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 40);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Location = new System.Drawing.Point(821, 423);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(45, 40);
            this.btnPhoneNumber.TabIndex = 14;
            this.btnPhoneNumber.Text = "...";
            this.btnPhoneNumber.Click += new System.EventHandler(this.btnPhoneNumber_Click);
            // 
            // bindingSourceMediums
            // 
            this.bindingSourceMediums.DataSource = typeof(MM.Model.Medium);
            // 
            // lkuMedium
            // 
            this.lkuMedium.Location = new System.Drawing.Point(396, 124);
            this.lkuMedium.Name = "lkuMedium";
            this.lkuMedium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuMedium.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 32, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lkuMedium.Properties.DataSource = this.bindingSourceMediums;
            this.lkuMedium.Properties.DisplayMember = "Name";
            this.lkuMedium.Properties.NullText = "";
            this.lkuMedium.Properties.ReadOnly = true;
            this.lkuMedium.Properties.ShowHeader = false;
            this.lkuMedium.Properties.ValueMember = "Id";
            this.lkuMedium.Size = new System.Drawing.Size(167, 36);
            this.lkuMedium.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(55, 188);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(94, 24);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "说 明：";
            // 
            // medtDescription
            // 
            this.medtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProducts, "Description", true));
            this.medtDescription.Location = new System.Drawing.Point(155, 183);
            this.medtDescription.Name = "medtDescription";
            this.medtDescription.Properties.ReadOnly = true;
            this.medtDescription.Size = new System.Drawing.Size(660, 211);
            this.medtDescription.TabIndex = 18;
            // 
            // FrmLecturePurchase
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(891, 602);
            this.ControlBox = false;
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.medtDescription);
            this.Controls.Add(this.lkuMedium);
            this.Controls.Add(this.btnPhoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lkuProduct);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLecturePurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "购买次卡";
            this.Load += new System.EventHandler(this.FrmTimesCardPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medtDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourcePurchase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkuProduct;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnPhoneNumber;
        private System.Windows.Forms.BindingSource bindingSourceProducts;
        private System.Windows.Forms.BindingSource bindingSourceMediums;
        private DevExpress.XtraEditors.LookUpEdit lkuMedium;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.MemoEdit medtDescription;
    }
}