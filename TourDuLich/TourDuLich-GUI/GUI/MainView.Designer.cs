﻿namespace TourDuLich_GUI.GUI
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.gridControl_Tours = new DevExpress.XtraGrid.GridControl();
            this.gridView_Tours = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bsiListCount = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl_Tours = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Tours = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage_TourGroups = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_TourGroups = new DevExpress.XtraGrid.GridControl();
            this.tourGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_TourGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Tours)).BeginInit();
            this.xtraTabControl_Tours.SuspendLayout();
            this.xtraTabPage_Tours.SuspendLayout();
            this.xtraTabPage_TourGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TourGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TourGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Tours
            // 
            this.gridControl_Tours.DataSource = typeof(TourDuLich_GUI.BUS.Tour);
            this.gridControl_Tours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Tours.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Tours.MainView = this.gridView_Tours;
            this.gridControl_Tours.MenuManager = this.ribbonControl;
            this.gridControl_Tours.Name = "gridControl_Tours";
            this.gridControl_Tours.Size = new System.Drawing.Size(788, 392);
            this.gridControl_Tours.TabIndex = 2;
            this.gridControl_Tours.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Tours});
            // 
            // gridView_Tours
            // 
            this.gridView_Tours.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView_Tours.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colPriceRef,
            this.colCurrentPrice});
            this.gridView_Tours.GridControl = this.gridControl_Tours;
            this.gridView_Tours.Name = "gridView_Tours";
            this.gridView_Tours.OptionsBehavior.Editable = false;
            this.gridView_Tours.OptionsBehavior.ReadOnly = true;
            this.gridView_Tours.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView_Tours.OptionsView.ShowFooter = true;
            this.gridView_Tours.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colPriceRef
            // 
            this.colPriceRef.DisplayFormat.FormatString = "N0";
            this.colPriceRef.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPriceRef.FieldName = "PriceRef";
            this.colPriceRef.Name = "colPriceRef";
            this.colPriceRef.Visible = true;
            this.colPriceRef.VisibleIndex = 2;
            // 
            // colCurrentPrice
            // 
            this.colCurrentPrice.DisplayFormat.FormatString = "N0";
            this.colCurrentPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCurrentPrice.FieldName = "CurrentPrice";
            this.colCurrentPrice.Name = "colCurrentPrice";
            this.colCurrentPrice.Visible = true;
            this.colCurrentPrice.VisibleIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bsiListCount});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Sửa";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xoá";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Nạp lại";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bsiListCount
            // 
            this.bsiListCount.Caption = "??? items";
            this.bsiListCount.Id = 20;
            this.bsiListCount.Name = "bsiListCount";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hành động";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiListCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 24);
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataSource = typeof(TourDuLich_GUI.BUS.Tour);
            // 
            // xtraTabControl_Tours
            // 
            this.xtraTabControl_Tours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_Tours.Location = new System.Drawing.Point(0, 158);
            this.xtraTabControl_Tours.Name = "xtraTabControl_Tours";
            this.xtraTabControl_Tours.SelectedTabPage = this.xtraTabPage_Tours;
            this.xtraTabControl_Tours.Size = new System.Drawing.Size(790, 417);
            this.xtraTabControl_Tours.TabIndex = 5;
            this.xtraTabControl_Tours.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Tours,
            this.xtraTabPage_TourGroups});
            this.xtraTabControl_Tours.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl_Tours_SelectedPageChanged);
            // 
            // xtraTabPage_Tours
            // 
            this.xtraTabPage_Tours.Controls.Add(this.gridControl_Tours);
            this.xtraTabPage_Tours.Name = "xtraTabPage_Tours";
            this.xtraTabPage_Tours.Size = new System.Drawing.Size(788, 392);
            this.xtraTabPage_Tours.Text = "Tour";
            // 
            // xtraTabPage_TourGroups
            // 
            this.xtraTabPage_TourGroups.Controls.Add(this.gridControl_TourGroups);
            this.xtraTabPage_TourGroups.Name = "xtraTabPage_TourGroups";
            this.xtraTabPage_TourGroups.Size = new System.Drawing.Size(788, 392);
            this.xtraTabPage_TourGroups.Text = "Đoàn Tour";
            // 
            // gridControl_TourGroups
            // 
            this.gridControl_TourGroups.DataSource = this.tourGroupBindingSource;
            this.gridControl_TourGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_TourGroups.Location = new System.Drawing.Point(0, 0);
            this.gridControl_TourGroups.MainView = this.gridView_TourGroups;
            this.gridControl_TourGroups.MenuManager = this.ribbonControl;
            this.gridControl_TourGroups.Name = "gridControl_TourGroups";
            this.gridControl_TourGroups.Size = new System.Drawing.Size(788, 392);
            this.gridControl_TourGroups.TabIndex = 0;
            this.gridControl_TourGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TourGroups});
            // 
            // tourGroupBindingSource
            // 
            this.tourGroupBindingSource.DataSource = typeof(TourDuLich_GUI.BUS.TourGroup);
            // 
            // gridView_TourGroups
            // 
            this.gridView_TourGroups.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView_TourGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTour,
            this.colName1,
            this.colDateStart,
            this.colDateEnd,
            this.colPriceGroup});
            this.gridView_TourGroups.GridControl = this.gridControl_TourGroups;
            this.gridView_TourGroups.Name = "gridView_TourGroups";
            // 
            // colTour
            // 
            this.colTour.FieldName = "Tour";
            this.colTour.Name = "colTour";
            this.colTour.Visible = true;
            this.colTour.VisibleIndex = 4;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colDateStart
            // 
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 1;
            // 
            // colDateEnd
            // 
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 2;
            // 
            // colPriceGroup
            // 
            this.colPriceGroup.DisplayFormat.FormatString = "N0";
            this.colPriceGroup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPriceGroup.FieldName = "PriceGroup";
            this.colPriceGroup.Name = "colPriceGroup";
            this.colPriceGroup.Visible = true;
            this.colPriceGroup.VisibleIndex = 3;
            // 
            // colCurrentPrice
            // 
            this.colCurrentPrice.Caption = "Giá hiện tại";
            this.colCurrentPrice.FieldName = "CurrentPrice";
            this.colCurrentPrice.Name = "colCurrentPrice";
            this.colCurrentPrice.Visible = true;
            this.colCurrentPrice.VisibleIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.xtraTabControl_Tours);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Tours)).EndInit();
            this.xtraTabControl_Tours.ResumeLayout(false);
            this.xtraTabPage_Tours.ResumeLayout(false);
            this.xtraTabPage_TourGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TourGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TourGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_Tours;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Tours;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarStaticItem bsiListCount;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRef;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_Tours;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Tours;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_TourGroups;
        private DevExpress.XtraGrid.GridControl gridControl_TourGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TourGroups;
        private System.Windows.Forms.BindingSource tourGroupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colTour;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPrice;
    }
}