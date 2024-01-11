namespace QL_CuaHang.UI.SanPham
{
    partial class UC_SanPham
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SanPham));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Print = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
			this.bh_TenChucNang = new DevExpress.XtraBars.BarHeaderItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
			this.gv_SanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gc_SanPham = new DevExpress.XtraGrid.GridControl();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Print,
            this.btn_Exit,
            this.bh_TenChucNang,
            this.btn_Add});
			this.barManager1.MaxItemId = 10;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bh_TenChucNang)});
			this.bar1.Text = "Tools";
			// 
			// btn_Edit
			// 
			this.btn_Edit.Caption = "Sửa";
			this.btn_Edit.Id = 0;
			this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
			this.btn_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.LargeImage")));
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Edit_ItemClick);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Caption = "Xóa";
			this.btn_Delete.Id = 4;
			this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
			this.btn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.LargeImage")));
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
			// 
			// btn_Print
			// 
			this.btn_Print.Caption = "In";
			this.btn_Print.Id = 5;
			this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
			this.btn_Print.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.LargeImage")));
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Caption = "Thoát";
			this.btn_Exit.Id = 6;
			this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
			this.btn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.LargeImage")));
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Exit_ItemClick);
			// 
			// bh_TenChucNang
			// 
			this.bh_TenChucNang.Id = 8;
			this.bh_TenChucNang.Name = "bh_TenChucNang";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(883, 30);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(883, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(883, 30);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
			// 
			// btn_Add
			// 
			this.btn_Add.Caption = "Thêm";
			this.btn_Add.Id = 9;
			this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
			this.btn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.LargeImage")));
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// gv_SanPham
			// 
			this.gv_SanPham.GridControl = this.gc_SanPham;
			this.gv_SanPham.Name = "gv_SanPham";
			this.gv_SanPham.OptionsBehavior.Editable = false;
			this.gv_SanPham.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gv_SanPham_RowCellStyle);
			this.gv_SanPham.ShownEditor += new System.EventHandler(this.gv_SanPham_ShownEditor);
			this.gv_SanPham.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_SanPham_CellValueChanged);
			this.gv_SanPham.DoubleClick += new System.EventHandler(this.gv_SanPham_DoubleClick);
			// 
			// gc_SanPham
			// 
			this.gc_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gc_SanPham.Location = new System.Drawing.Point(0, 30);
			this.gc_SanPham.MainView = this.gv_SanPham;
			this.gc_SanPham.MenuManager = this.barManager1;
			this.gc_SanPham.Name = "gc_SanPham";
			this.gc_SanPham.Size = new System.Drawing.Size(883, 511);
			this.gc_SanPham.TabIndex = 4;
			this.gc_SanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SanPham});
			// 
			// UC_SanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gc_SanPham);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "UC_SanPham";
			this.Size = new System.Drawing.Size(883, 541);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gc_SanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SanPham;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Print;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.BarHeaderItem bh_TenChucNang;
		private DevExpress.XtraBars.BarButtonItem btn_Add;
	}
}
