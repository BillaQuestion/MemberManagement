namespace MM.UI
{
    partial class FrmTimesCard
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
            this.bindingSourceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkuMedium = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceMediums = new System.Windows.Forms.BindingSource(this.components);
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            countLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            mediumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(56, 148);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 24);
            countLabel.TabIndex = 2;
            countLabel.Text = "次  数：";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(56, 81);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(106, 24);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "名  称：";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(56, 272);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(106, 24);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "价  格：";
            // 
            // mediumLabel
            // 
            mediumLabel.AutoSize = true;
            mediumLabel.Location = new System.Drawing.Point(56, 212);
            mediumLabel.Name = "mediumLabel";
            mediumLabel.Size = new System.Drawing.Size(106, 24);
            mediumLabel.TabIndex = 4;
            mediumLabel.Text = "介  质：";
            // 
            // bindingSourceProduct
            // 
            this.bindingSourceProduct.DataSource = typeof(MM.Model.TimesCard);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Name", true));
            this.txtName.Location = new System.Drawing.Point(168, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(168, 269);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(402, 36);
            this.txtPrice.TabIndex = 7;
            // 
            // lkuMedium
            // 
            this.lkuMedium.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "MediumId", true));
            this.lkuMedium.Location = new System.Drawing.Point(168, 206);
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
            this.lkuMedium.Size = new System.Drawing.Size(402, 36);
            this.lkuMedium.TabIndex = 5;
            // 
            // bindingSourceMediums
            // 
            this.bindingSourceMediums.DataSource = typeof(MM.Model.Medium);
            // 
            // txtCount
            // 
            this.txtCount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceProduct, "Count", true));
            this.txtCount.Location = new System.Drawing.Point(168, 142);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(402, 36);
            this.txtCount.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(186, 353);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 40);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(378, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmTimesCard
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(633, 428);
            this.ControlBox = false;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTimesCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "次卡";
            this.Load += new System.EventHandler(this.FrmTimesCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMedium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
    }
}