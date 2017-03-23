namespace MM.UI.Controls
{
    partial class CtrlTimesCardConsume
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnPhoneNumber = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnConsume = new DevExpress.XtraEditors.SimpleButton();
            this.grdCtrlMemberCard = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMemberCard = new System.Windows.Forms.BindingSource(this.components);
            this.grdViewMemberCard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMediumName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlConsumption = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceConsumption = new System.Windows.Forms.BindingSource(this.components);
            this.grdViewConsumption = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberProductId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlMemberCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMemberCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMemberCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "手机号码：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(172, 38);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(305, 36);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Location = new System.Drawing.Point(498, 36);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(50, 36);
            this.btnPhoneNumber.TabIndex = 2;
            this.btnPhoneNumber.Text = "...";
            this.btnPhoneNumber.Click += new System.EventHandler(this.btnPhoneNumber_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(621, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 29);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "姓 名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(707, 38);
            this.txtName.Name = "txtName";
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(210, 36);
            this.txtName.TabIndex = 4;
            // 
            // btnConsume
            // 
            this.btnConsume.Location = new System.Drawing.Point(964, 36);
            this.btnConsume.Name = "btnConsume";
            this.btnConsume.Size = new System.Drawing.Size(161, 36);
            this.btnConsume.TabIndex = 5;
            this.btnConsume.Text = "消 费";
            this.btnConsume.Click += new System.EventHandler(this.btnConsume_Click);
            // 
            // grdCtrlMemberCard
            // 
            this.grdCtrlMemberCard.DataSource = this.bindingSourceMemberCard;
            this.grdCtrlMemberCard.Location = new System.Drawing.Point(46, 149);
            this.grdCtrlMemberCard.MainView = this.grdViewMemberCard;
            this.grdCtrlMemberCard.Name = "grdCtrlMemberCard";
            this.grdCtrlMemberCard.Size = new System.Drawing.Size(1070, 358);
            this.grdCtrlMemberCard.TabIndex = 6;
            this.grdCtrlMemberCard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewMemberCard});
            // 
            // bindingSourceMemberCard
            // 
            this.bindingSourceMemberCard.DataSource = typeof(MM.Model.MemberCard);
            // 
            // grdViewMemberCard
            // 
            this.grdViewMemberCard.Appearance.EvenRow.BackColor = System.Drawing.Color.GhostWhite;
            this.grdViewMemberCard.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewMemberCard.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdViewMemberCard.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdViewMemberCard.ColumnPanelRowHeight = 24;
            this.grdViewMemberCard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.colMemberProductId,
            this.colMediumName,
            this.colCount,
            this.colPurchaseDate,
            this.colRemainder,
            this.colId});
            this.grdViewMemberCard.GridControl = this.grdCtrlMemberCard;
            this.grdViewMemberCard.Name = "grdViewMemberCard";
            this.grdViewMemberCard.OptionsBehavior.Editable = false;
            this.grdViewMemberCard.OptionsView.ShowGroupPanel = false;
            this.grdViewMemberCard.RowHeight = 24;
            this.grdViewMemberCard.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewMemberCard_FocusedRowChanged);
            // 
            // colProduct
            // 
            this.colProduct.Caption = "会员卡名称";
            this.colProduct.FieldName = "Product.Name";
            this.colProduct.Name = "colProduct";
            this.colProduct.OptionsColumn.AllowFocus = false;
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // colMemberProductId
            // 
            this.colMemberProductId.FieldName = "MemberProductId";
            this.colMemberProductId.Name = "colMemberProductId";
            this.colMemberProductId.OptionsColumn.AllowFocus = false;
            // 
            // colMediumName
            // 
            this.colMediumName.Caption = "介质";
            this.colMediumName.FieldName = "MediumName";
            this.colMediumName.Name = "colMediumName";
            this.colMediumName.OptionsColumn.AllowFocus = false;
            this.colMediumName.Visible = true;
            this.colMediumName.VisibleIndex = 1;
            // 
            // colCount
            // 
            this.colCount.Caption = "总次数";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.AllowFocus = false;
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.Caption = "购买日期";
            this.colPurchaseDate.DisplayFormat.FormatString = "“yyyy-MM-dd\"";
            this.colPurchaseDate.FieldName = "PurchaseDate";
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.OptionsColumn.AllowFocus = false;
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 4;
            // 
            // colRemainder
            // 
            this.colRemainder.Caption = "剩余次数";
            this.colRemainder.FieldName = "Remainder";
            this.colRemainder.Name = "colRemainder";
            this.colRemainder.OptionsColumn.AllowFocus = false;
            this.colRemainder.Visible = true;
            this.colRemainder.VisibleIndex = 3;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 29);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "所购会员卡：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 531);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 29);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "消费记录：";
            // 
            // grdCtrlConsumption
            // 
            this.grdCtrlConsumption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdCtrlConsumption.DataSource = this.bindingSourceConsumption;
            this.grdCtrlConsumption.Location = new System.Drawing.Point(46, 566);
            this.grdCtrlConsumption.MainView = this.grdViewConsumption;
            this.grdCtrlConsumption.Name = "grdCtrlConsumption";
            this.grdCtrlConsumption.Size = new System.Drawing.Size(1079, 534);
            this.grdCtrlConsumption.TabIndex = 9;
            this.grdCtrlConsumption.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewConsumption});
            // 
            // bindingSourceConsumption
            // 
            this.bindingSourceConsumption.DataSource = typeof(MM.Model.Consumption);
            // 
            // grdViewConsumption
            // 
            this.grdViewConsumption.Appearance.EvenRow.BackColor = System.Drawing.Color.GhostWhite;
            this.grdViewConsumption.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewConsumption.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdViewConsumption.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdViewConsumption.ColumnPanelRowHeight = 24;
            this.grdViewConsumption.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberId,
            this.colMember,
            this.colMemberProduct,
            this.colMemberProductId1,
            this.colConsumeDate,
            this.colTutor,
            this.colTutorId,
            this.colId1});
            this.grdViewConsumption.GridControl = this.grdCtrlConsumption;
            this.grdViewConsumption.Name = "grdViewConsumption";
            this.grdViewConsumption.OptionsBehavior.Editable = false;
            this.grdViewConsumption.OptionsView.ShowGroupPanel = false;
            this.grdViewConsumption.RowHeight = 24;
            // 
            // colMemberId
            // 
            this.colMemberId.FieldName = "MemberId";
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.OptionsColumn.AllowFocus = false;
            // 
            // colMember
            // 
            this.colMember.FieldName = "Member";
            this.colMember.Name = "colMember";
            this.colMember.OptionsColumn.AllowFocus = false;
            // 
            // colMemberProduct
            // 
            this.colMemberProduct.FieldName = "MemberProduct";
            this.colMemberProduct.Name = "colMemberProduct";
            this.colMemberProduct.OptionsColumn.AllowFocus = false;
            // 
            // colMemberProductId1
            // 
            this.colMemberProductId1.FieldName = "MemberProductId";
            this.colMemberProductId1.Name = "colMemberProductId1";
            this.colMemberProductId1.OptionsColumn.AllowFocus = false;
            // 
            // colConsumeDate
            // 
            this.colConsumeDate.Caption = "消费日期";
            this.colConsumeDate.DisplayFormat.FormatString = "\"yyyy-MM-dd\"";
            this.colConsumeDate.FieldName = "ConsumeDate";
            this.colConsumeDate.Name = "colConsumeDate";
            this.colConsumeDate.OptionsColumn.AllowFocus = false;
            this.colConsumeDate.Visible = true;
            this.colConsumeDate.VisibleIndex = 0;
            // 
            // colTutor
            // 
            this.colTutor.Caption = "教师";
            this.colTutor.FieldName = "Tutor.Name";
            this.colTutor.Name = "colTutor";
            this.colTutor.OptionsColumn.AllowFocus = false;
            this.colTutor.Visible = true;
            this.colTutor.VisibleIndex = 1;
            // 
            // colTutorId
            // 
            this.colTutorId.FieldName = "TutorId";
            this.colTutorId.Name = "colTutorId";
            this.colTutorId.OptionsColumn.AllowFocus = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowFocus = false;
            this.colId1.OptionsColumn.ReadOnly = true;
            // 
            // CtrlTimesCardConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grdCtrlConsumption);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdCtrlMemberCard);
            this.Controls.Add(this.btnConsume);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.labelControl1);
            this.Name = "CtrlTimesCardConsume";
            this.Size = new System.Drawing.Size(1666, 1116);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlMemberCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMemberCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMemberCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnConsume;
        private DevExpress.XtraGrid.GridControl grdCtrlMemberCard;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewMemberCard;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bindingSourceMemberCard;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colMediumName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainder;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdCtrlConsumption;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewConsumption;
        private System.Windows.Forms.BindingSource bindingSourceConsumption;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraGrid.Columns.GridColumn colMember;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberProductId1;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTutor;
        private DevExpress.XtraGrid.Columns.GridColumn colTutorId;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
    }
}
