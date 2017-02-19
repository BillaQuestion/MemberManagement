namespace MM.UI.Controls
{
    partial class CtrlTimesCardManagement
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
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grdCtrlProducts = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedium = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMediumId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditMedium = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceMediums = new System.Windows.Forms.BindingSource(this.components);
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).BeginInit();
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
            this.bbiRefresh});
            this.barManager.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh)});
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
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "刷新";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1328, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1116);
            this.barDockControlBottom.Size = new System.Drawing.Size(1328, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1058);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1328, 58);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1058);
            // 
            // grdCtrlProducts
            // 
            this.grdCtrlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdCtrlProducts.DataSource = this.bindingSourceProducts;
            this.grdCtrlProducts.Location = new System.Drawing.Point(3, 64);
            this.grdCtrlProducts.MainView = this.gridViewProducts;
            this.grdCtrlProducts.MenuManager = this.barManager;
            this.grdCtrlProducts.Name = "grdCtrlProducts";
            this.grdCtrlProducts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditMedium});
            this.grdCtrlProducts.Size = new System.Drawing.Size(1145, 1049);
            this.grdCtrlProducts.TabIndex = 5;
            this.grdCtrlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // bindingSourceProducts
            // 
            this.bindingSourceProducts.DataSource = typeof(MM.Model.TimesCard);
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Appearance.EvenRow.BackColor = System.Drawing.Color.GhostWhite;
            this.gridViewProducts.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewProducts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProducts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProducts.ColumnPanelRowHeight = 24;
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colMedium,
            this.colMediumId,
            this.colCount,
            this.colPrice,
            this.colId});
            this.gridViewProducts.GridControl = this.grdCtrlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.Editable = false;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.RowHeight = 24;
            // 
            // colName
            // 
            this.colName.Caption = "产品名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 1057;
            // 
            // colMedium
            // 
            this.colMedium.FieldName = "Medium";
            this.colMedium.Name = "colMedium";
            this.colMedium.OptionsColumn.AllowFocus = false;
            this.colMedium.Width = 522;
            // 
            // colMediumId
            // 
            this.colMediumId.AppearanceCell.Options.UseTextOptions = true;
            this.colMediumId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMediumId.Caption = "介质";
            this.colMediumId.ColumnEdit = this.repositoryItemLookUpEditMedium;
            this.colMediumId.FieldName = "MediumId";
            this.colMediumId.Name = "colMediumId";
            this.colMediumId.OptionsColumn.AllowFocus = false;
            this.colMediumId.Visible = true;
            this.colMediumId.VisibleIndex = 1;
            this.colMediumId.Width = 465;
            // 
            // repositoryItemLookUpEditMedium
            // 
            this.repositoryItemLookUpEditMedium.AutoHeight = false;
            this.repositoryItemLookUpEditMedium.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditMedium.DataSource = this.bindingSourceMediums;
            this.repositoryItemLookUpEditMedium.DisplayMember = "Name";
            this.repositoryItemLookUpEditMedium.Name = "repositoryItemLookUpEditMedium";
            this.repositoryItemLookUpEditMedium.NullText = "";
            this.repositoryItemLookUpEditMedium.ValueMember = "Id";
            // 
            // bindingSourceMediums
            // 
            this.bindingSourceMediums.DataSource = typeof(MM.Model.Medium);
            // 
            // colCount
            // 
            this.colCount.AppearanceCell.Options.UseTextOptions = true;
            this.colCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCount.Caption = "次数";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.AllowFocus = false;
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            this.colCount.Width = 454;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "价格";
            this.colPrice.DisplayFormat.FormatString = "0.00";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 454;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // CtrlTimesCardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grdCtrlProducts);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CtrlTimesCardManagement";
            this.Size = new System.Drawing.Size(1328, 1116);
            this.Load += new System.EventHandler(this.CtrlTimesCardManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiAddNew;
        private DevExpress.XtraBars.BarButtonItem bbiModify;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grdCtrlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private System.Windows.Forms.BindingSource bindingSourceProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMedium;
        private DevExpress.XtraGrid.Columns.GridColumn colMediumId;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditMedium;
        private System.Windows.Forms.BindingSource bindingSourceMediums;
    }
}
