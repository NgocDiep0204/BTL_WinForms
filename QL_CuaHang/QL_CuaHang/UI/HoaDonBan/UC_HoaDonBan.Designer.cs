namespace QL_CuaHang.UI.HoaDonBan
{
    partial class UC_HoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HoaDonBan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Show = new DevExpress.XtraBars.BarButtonItem();
            this.s = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panel_ChiTietHDB = new System.Windows.Forms.Panel();
            this.gc_ChiTietHDB = new DevExpress.XtraGrid.GridControl();
            this.gv_ChiTietHDB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_HoaDonBan = new System.Windows.Forms.Panel();
            this.gc_HoaDonBan = new DevExpress.XtraGrid.GridControl();
            this.gv_HoaDonBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_Ngay = new System.Windows.Forms.DateTimePicker();
            this.cbo_MaKH = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DoanhThu = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.panel_ChiTietHDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChiTietHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietHDB)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_HoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_HoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.btn_Show,
            this.s});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Show),
            new DevExpress.XtraBars.LinkPersistInfo(this.s)});
            this.bar1.Text = "Tools";
            // 
            // btn_Show
            // 
            this.btn_Show.Caption = "Chi tiết hoá đơn";
            this.btn_Show.Id = 0;
            this.btn_Show.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show.ImageOptions.Image")));
            this.btn_Show.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Show.ImageOptions.LargeImage")));
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Show.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Show_ItemClick);
            // 
            // s
            // 
            this.s.Caption = "barButtonItem2";
            this.s.Id = 1;
            this.s.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("s.ImageOptions.Image")));
            this.s.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("s.ImageOptions.LargeImage")));
            this.s.Name = "s";
            this.s.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Shorten_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1220, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 640);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1220, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1220, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // panel_ChiTietHDB
            // 
            this.panel_ChiTietHDB.Controls.Add(this.gc_ChiTietHDB);
            this.panel_ChiTietHDB.Controls.Add(this.panel2);
            this.panel_ChiTietHDB.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ChiTietHDB.Location = new System.Drawing.Point(643, 34);
            this.panel_ChiTietHDB.Name = "panel_ChiTietHDB";
            this.panel_ChiTietHDB.Size = new System.Drawing.Size(577, 606);
            this.panel_ChiTietHDB.TabIndex = 4;
            // 
            // gc_ChiTietHDB
            // 
            this.gc_ChiTietHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ChiTietHDB.Location = new System.Drawing.Point(0, 52);
            this.gc_ChiTietHDB.MainView = this.gv_ChiTietHDB;
            this.gc_ChiTietHDB.MenuManager = this.barManager1;
            this.gc_ChiTietHDB.Name = "gc_ChiTietHDB";
            this.gc_ChiTietHDB.Size = new System.Drawing.Size(577, 554);
            this.gc_ChiTietHDB.TabIndex = 1;
            this.gc_ChiTietHDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ChiTietHDB});
            // 
            // gv_ChiTietHDB
            // 
            this.gv_ChiTietHDB.GridControl = this.gc_ChiTietHDB;
            this.gv_ChiTietHDB.Name = "gv_ChiTietHDB";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 52);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết hoá đơn bán";
            // 
            // panel_HoaDonBan
            // 
            this.panel_HoaDonBan.Controls.Add(this.gc_HoaDonBan);
            this.panel_HoaDonBan.Controls.Add(this.panelControl1);
            this.panel_HoaDonBan.Controls.Add(this.panel3);
            this.panel_HoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_HoaDonBan.Location = new System.Drawing.Point(0, 34);
            this.panel_HoaDonBan.Name = "panel_HoaDonBan";
            this.panel_HoaDonBan.Size = new System.Drawing.Size(643, 606);
            this.panel_HoaDonBan.TabIndex = 5;
            // 
            // gc_HoaDonBan
            // 
            this.gc_HoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_HoaDonBan.Location = new System.Drawing.Point(0, 154);
            this.gc_HoaDonBan.MainView = this.gv_HoaDonBan;
            this.gc_HoaDonBan.MenuManager = this.barManager1;
            this.gc_HoaDonBan.Name = "gc_HoaDonBan";
            this.gc_HoaDonBan.Size = new System.Drawing.Size(643, 352);
            this.gc_HoaDonBan.TabIndex = 3;
            this.gc_HoaDonBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HoaDonBan});
            // 
            // gv_HoaDonBan
            // 
            this.gv_HoaDonBan.GridControl = this.gc_HoaDonBan;
            this.gv_HoaDonBan.Name = "gv_HoaDonBan";
            this.gv_HoaDonBan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_HoaDonBan_RowCellClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.btn_Search);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.date_Ngay);
            this.panelControl1.Controls.Add(this.cbo_MaKH);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(643, 154);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.ImageOptions.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(457, 66);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 29);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Huỷ bỏ";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(457, 108);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 34);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày lập hoá đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sdt khách hàng:";
            // 
            // date_Ngay
            // 
            this.date_Ngay.CustomFormat = "MM/yyyy";
            this.date_Ngay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Ngay.Location = new System.Drawing.Point(228, 110);
            this.date_Ngay.Name = "date_Ngay";
            this.date_Ngay.Size = new System.Drawing.Size(200, 27);
            this.date_Ngay.TabIndex = 6;
            // 
            // cbo_MaKH
            // 
            this.cbo_MaKH.FormattingEnabled = true;
            this.cbo_MaKH.Location = new System.Drawing.Point(228, 66);
            this.cbo_MaKH.Name = "cbo_MaKH";
            this.cbo_MaKH.Size = new System.Drawing.Size(190, 27);
            this.cbo_MaKH.TabIndex = 5;
            this.cbo_MaKH.SelectedIndexChanged += new System.EventHandler(this.cbo_MaKH_SelectedIndexChanged);
            this.cbo_MaKH.Click += new System.EventHandler(this.cbo_MaKH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hoá đơn bán";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_DoanhThu);
            this.panel3.Controls.Add(this.lbl_SoLuong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 100);
            this.panel3.TabIndex = 1;
            // 
            // lbl_DoanhThu
            // 
            this.lbl_DoanhThu.AutoSize = true;
            this.lbl_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhThu.Location = new System.Drawing.Point(38, 60);
            this.lbl_DoanhThu.Name = "lbl_DoanhThu";
            this.lbl_DoanhThu.Size = new System.Drawing.Size(0, 22);
            this.lbl_DoanhThu.TabIndex = 1;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(38, 16);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(0, 22);
            this.lbl_SoLuong.TabIndex = 0;
            // 
            // UC_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_HoaDonBan);
            this.Controls.Add(this.panel_ChiTietHDB);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_HoaDonBan";
            this.Size = new System.Drawing.Size(1220, 640);
            this.Load += new System.EventHandler(this.UC_HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.panel_ChiTietHDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChiTietHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietHDB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_HoaDonBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_HoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Show;
        private DevExpress.XtraBars.BarButtonItem s;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Panel panel_HoaDonBan;
        private System.Windows.Forms.Panel panel_ChiTietHDB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_DoanhThu;
        private System.Windows.Forms.Label lbl_SoLuong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbo_MaKH;
        private System.Windows.Forms.DateTimePicker date_Ngay;
        private DevExpress.XtraGrid.GridControl gc_HoaDonBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HoaDonBan;
        private DevExpress.XtraGrid.GridControl gc_ChiTietHDB;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChiTietHDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}
