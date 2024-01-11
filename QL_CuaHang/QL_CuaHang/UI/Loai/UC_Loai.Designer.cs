namespace QL_CuaHang.UI.Loai
{
    partial class UC_Loai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Loai));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_Maloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_Loai = new DevExpress.XtraGrid.GridControl();
            this.gv_Loai = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Loai)).BeginInit();
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
            this.btn_them,
            this.btn_Sua,
            this.btn_Xoa});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Sua)});
            this.bar1.Text = "Tools";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.LargeImage")));
            this.btn_them.Name = "btn_them";
            this.btn_them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa";
            this.btn_Sua.Id = 1;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.LargeImage")));
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Sua_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(848, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(848, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(848, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xoá";
            this.btn_Xoa.Id = 2;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.LargeImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Huy);
            this.panelControl1.Controls.Add(this.cbo_Maloai);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(848, 104);
            this.panelControl1.TabIndex = 4;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(609, 55);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(112, 34);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Huỷ bỏ";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // cbo_Maloai
            // 
            this.cbo_Maloai.FormattingEnabled = true;
            this.cbo_Maloai.Location = new System.Drawing.Point(276, 60);
            this.cbo_Maloai.Name = "cbo_Maloai";
            this.cbo_Maloai.Size = new System.Drawing.Size(238, 27);
            this.cbo_Maloai.TabIndex = 2;
            this.cbo_Maloai.SelectedIndexChanged += new System.EventHandler(this.cbo_Maloai_SelectedIndexChanged);
            this.cbo_Maloai.Click += new System.EventHandler(this.cbo_Maloai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng";
            // 
            // gc_Loai
            // 
            this.gc_Loai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Loai.Location = new System.Drawing.Point(0, 138);
            this.gc_Loai.MainView = this.gv_Loai;
            this.gc_Loai.MenuManager = this.barManager1;
            this.gc_Loai.Name = "gc_Loai";
            this.gc_Loai.Size = new System.Drawing.Size(848, 354);
            this.gc_Loai.TabIndex = 9;
            this.gc_Loai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Loai});
            // 
            // gv_Loai
            // 
            this.gv_Loai.GridControl = this.gc_Loai;
            this.gv_Loai.Name = "gv_Loai";
            this.gv_Loai.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gv_Loai_ShowingEditor);
            this.gv_Loai.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_Loai_CellValueChanged);
            // 
            // UC_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_Loai);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_Loai";
            this.Size = new System.Drawing.Size(848, 492);
            this.Load += new System.EventHandler(this.UC_Loai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Loai)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private System.Windows.Forms.ComboBox cbo_Maloai;
        private DevExpress.XtraGrid.GridControl gc_Loai;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Loai;
    }
}
