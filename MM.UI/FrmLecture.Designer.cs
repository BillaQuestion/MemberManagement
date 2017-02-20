namespace MM.UI
{
    partial class FrmLecture
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
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label mediumLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.bindingSourceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkuMedium = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceMediums = new System.Windows.Forms.BindingSource(this.components);
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            countLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            mediumLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(298, 43);
            countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(53, 12);
            countLabel.TabIndex = 2;
            countLabel.Text = "次  数：";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(28, 40);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 12);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "名  称：";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(299, 73);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(53, 12);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "价  格：";
            // 
            // mediumLabel
            // 
            mediumLabel.AutoSize = true;
            mediumLabel.Location = new System.Drawing.Point(28, 74);
            mediumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mediumLabel.Name = "mediumLabel";
            mediumLabel.Size = new System.Drawing.Size(53, 12);
            mediumLabel.TabIndex = 4;
            mediumLabel.Text = "介  质：";
            // 
            // bindingSourceProduct
            // 
            this.bindingSourceProduct.DataSource = typeof(MM.Model.Lecture);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Name", true));
            this.txtName.Location = new System.Drawing.Point(84, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(355, 71);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lkuMedium
            // 
            this.lkuMedium.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "MediumId", true));
            this.lkuMedium.Location = new System.Drawing.Point(84, 71);
            this.lkuMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lkuMedium.Name = "lkuMedium";
            this.lkuMedium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuMedium.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkuMedium.Properties.DataSource = this.bindingSourceMediums;
            this.lkuMedium.Properties.DisplayMember = "Name";
            this.lkuMedium.Properties.NullText = "";
            this.lkuMedium.Properties.ShowFooter = false;
            this.lkuMedium.Properties.ShowHeader = false;
            this.lkuMedium.Properties.ValueMember = "Id";
            this.lkuMedium.Size = new System.Drawing.Size(187, 20);
            this.lkuMedium.TabIndex = 5;
            // 
            // bindingSourceMediums
            // 
            this.bindingSourceMediums.DataSource = typeof(MM.Model.Medium);
            // 
            // txtCount
            // 
            this.txtCount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Count", true));
            this.txtCount.Location = new System.Drawing.Point(355, 38);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 20);
            this.txtCount.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(175, 246);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 20);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(271, 246);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 20);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(16, 113);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(65, 12);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "课程说明：";
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Description", true));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(84, 109);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(375, 123);
            this.descriptionMemoEdit.TabIndex = 9;
            // 
            // FrmLecture
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(486, 285);
            this.ControlBox = false;
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(mediumLabel);
            this.Controls.Add(this.lkuMedium);
            this.Controls.Add(countLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLecture";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "课程";
            this.Load += new System.EventHandler(this.FrmLecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceProduct;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LookUpEdit lkuMedium;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.BindingSource bindingSourceMediums;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
    }
}