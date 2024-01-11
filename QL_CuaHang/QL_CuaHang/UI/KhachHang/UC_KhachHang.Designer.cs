namespace QL_CuaHang.UI.KhachHang
{
    partial class UC_KhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Print = new DevExpress.XtraBars.BarButtonItem();
            this.bh_TenChucNang = new DevExpress.XtraBars.BarHeaderItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gc_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.gv_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Add,
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Print,
            this.bh_TenChucNang,
            this.btn_Thoat,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.bh_TenChucNang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Thêm";
            this.btn_Add.Id = 0;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.LargeImage")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Add_ItemClick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Caption = "Sửa";
            this.btn_Edit.Id = 1;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.LargeImage")));
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Edit_ItemClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Xoá";
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.LargeImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Print
            // 
            this.btn_Print.Caption = "In ";
            this.btn_Print.Id = 3;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.LargeImage")));
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bh_TenChucNang
            // 
            this.bh_TenChucNang.Caption = "View";
            this.bh_TenChucNang.Id = 4;
            this.bh_TenChucNang.Name = "bh_TenChucNang";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 5;
            this.btn_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.Image")));
            this.btn_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.LargeImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(960, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 567);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(960, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(960, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
            // 
            // gc_KhachHang
            // 
            this.gc_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_KhachHang.Location = new System.Drawing.Point(0, 34);
            this.gc_KhachHang.MainView = this.gv_KhachHang;
            this.gc_KhachHang.MenuManager = this.barManager1;
            this.gc_KhachHang.Name = "gc_KhachHang";
            this.gc_KhachHang.Size = new System.Drawing.Size(960, 533);
            this.gc_KhachHang.TabIndex = 4;
            this.gc_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KhachHang});
            this.gc_KhachHang.Load += new System.EventHandler(this.gc_KhachHang_Load);
            this.gc_KhachHang.Click += new System.EventHandler(this.gc_KhachHang_Click);
            // 
            // gv_KhachHang
            // 
            this.gv_KhachHang.GridControl = this.gc_KhachHang;
            this.gv_KhachHang.Name = "gv_KhachHang";
            this.gv_KhachHang.ShownEditor += new System.EventHandler(this.gv_KhachHang_ShownEditor);
            this.gv_KhachHang.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_KhachHang_CellValueChanged);
            this.gv_KhachHang.RowEditCanceled += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_KhachHang_RowEditCanceled);
            this.gv_KhachHang.DoubleClick += new System.EventHandler(this.gv_KhachHang_DoubleClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_KhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(960, 567);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Print;
        private DevExpress.XtraGrid.GridControl gc_KhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KhachHang;
        private DevExpress.XtraBars.BarHeaderItem bh_TenChucNang;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
