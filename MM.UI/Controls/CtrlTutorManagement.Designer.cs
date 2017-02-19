namespace MM.UI.Controls
{
    partial class CtrlTutorManagement
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiModify = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grdTutors = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceTutors = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTutors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTutors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTutors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTutors)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAddNew,
            this.bbiModify,
            this.bbiDelete,
            this.bbiChangePassword});
            this.barManager.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChangePassword)});
            this.bar1.Text = "Tools";
            // 
            // bbiAddNew
            // 
            this.bbiAddNew.Caption = "新建";
            this.bbiAddNew.Id = 0;
            this.bbiAddNew.Name = "bbiAddNew";
            this.bbiAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNew_ItemClick);
            // 
            // bbiModify
            // 
            this.bbiModify.Caption = "修改";
            this.bbiModify.Id = 1;
            this.bbiModify.Name = "bbiModify";
            this.bbiModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModify_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除";
            this.bbiDelete.Id = 2;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiChangePassword
            // 
            this.bbiChangePassword.Caption = "修改密码";
            this.bbiChangePassword.Id = 3;
            this.bbiChangePassword.Name = "bbiChangePassword";
            this.bbiChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePassword_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1327, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1094);
            this.barDockControlBottom.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1036);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1327, 58);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1036);
            // 
            // grdTutors
            // 
            this.grdTutors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdTutors.DataSource = this.bindingSourceTutors;
            this.grdTutors.Location = new System.Drawing.Point(3, 64);
            this.grdTutors.MainView = this.gridViewTutors;
            this.grdTutors.MenuManager = this.barManager;
            this.grdTutors.Name = "grdTutors";
            this.grdTutors.Size = new System.Drawing.Size(1125, 1027);
            this.grdTutors.TabIndex = 4;
            this.grdTutors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTutors});
            // 
            // bindingSourceTutors
            // 
            this.bindingSourceTutors.DataSource = typeof(MM.Model.Tutor);
            // 
            // gridViewTutors
            // 
            this.gridViewTutors.Appearance.EvenRow.BackColor = System.Drawing.Color.GhostWhite;
            this.gridViewTutors.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewTutors.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewTutors.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTutors.ColumnPanelRowHeight = 24;
            this.gridViewTutors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPassword,
            this.colGender,
            this.colPhoneNumber,
            this.colAddress,
            this.colIsManager,
            this.colId});
            this.gridViewTutors.GridControl = this.grdTutors;
            this.gridViewTutors.Name = "gridViewTutors";
            this.gridViewTutors.OptionsView.ShowGroupPanel = false;
            this.gridViewTutors.RowHeight = 24;
            // 
            // colName
            // 
            this.colName.Caption = "姓名";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 137;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.Caption = "性别";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 1;
            this.colGender.Width = 113;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "联系电话";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            this.colPhoneNumber.Width = 239;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "联系地址";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 462;
            // 
            // colIsManager
            // 
            this.colIsManager.Caption = "是否为管理员";
            this.colIsManager.FieldName = "IsManager";
            this.colIsManager.Name = "colIsManager";
            this.colIsManager.Visible = true;
            this.colIsManager.VisibleIndex = 2;
            this.colIsManager.Width = 140;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // CtrlTutorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grdTutors);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CtrlTutorManagement";
            this.Size = new System.Drawing.Size(1327, 1094);
            this.Load += new System.EventHandler(this.CtrlTutorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTutors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTutors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTutors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAddNew;
        private DevExpress.XtraBars.BarButtonItem bbiModify;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraGrid.GridControl grdTutors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTutors;
        private System.Windows.Forms.BindingSource bindingSourceTutors;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colIsManager;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
