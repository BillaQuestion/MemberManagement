﻿namespace MM.UI
{
    partial class FrmTutor
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label isManagerLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label genderLabel;
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.chkIsManager = new DevExpress.XtraEditors.CheckEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.lkuGender = new DevExpress.XtraEditors.LookUpEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSourceTutor = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            isManagerLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(67, 223);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(130, 24);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "地    址：";
            // 
            // isManagerLabel
            // 
            isManagerLabel.AutoSize = true;
            isManagerLabel.Location = new System.Drawing.Point(43, 286);
            isManagerLabel.Name = "isManagerLabel";
            isManagerLabel.Size = new System.Drawing.Size(154, 24);
            isManagerLabel.TabIndex = 8;
            isManagerLabel.Text = "是否管理员：";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(67, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(130, 24);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "姓    名：";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(67, 155);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(130, 24);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "联系电话：";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(539, 88);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(82, 24);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "性别：";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceTutor, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(203, 217);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(566, 36);
            this.txtAddress.TabIndex = 7;
            // 
            // chkIsManager
            // 
            this.chkIsManager.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceTutor, "IsManager", true));
            this.chkIsManager.Location = new System.Drawing.Point(203, 283);
            this.chkIsManager.Name = "chkIsManager";
            this.chkIsManager.Properties.Caption = "";
            this.chkIsManager.Size = new System.Drawing.Size(100, 34);
            this.chkIsManager.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceTutor, "Name", true));
            this.txtName.Location = new System.Drawing.Point(203, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceTutor, "PhoneNumber", true));
            this.txtPhoneNumber.Location = new System.Drawing.Point(203, 149);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(566, 36);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(279, 345);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(133, 38);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(460, 345);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(133, 38);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "取消";
            // 
            // lkuGender
            // 
            this.lkuGender.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceTutor, "Gender", true));
            this.lkuGender.Location = new System.Drawing.Point(627, 82);
            this.lkuGender.Name = "lkuGender";
            this.lkuGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuGender.Properties.NullText = "";
            this.lkuGender.Size = new System.Drawing.Size(142, 36);
            this.lkuGender.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bindingSourceTutor
            // 
            this.bindingSourceTutor.DataSource = typeof(MM.Model.Tutor);
            // 
            // FrmTutor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(843, 418);
            this.ControlBox = false;
            this.Controls.Add(this.lkuGender);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(isManagerLabel);
            this.Controls.Add(this.chkIsManager);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.txtPhoneNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTutor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教师";
            this.Load += new System.EventHandler(this.FrmTutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceTutor;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.CheckEdit chkIsManager;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.LookUpEdit lkuGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}