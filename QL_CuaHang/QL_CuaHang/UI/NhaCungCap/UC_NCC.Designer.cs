namespace QL_CuaHang.UI.NhaCungCap
{
    partial class UC_NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NCC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_MaNcc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_NhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gv_NhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhaCungCap)).BeginInit();
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
            this.btn_Add,
            this.btn_Edit,
            this.btn_Delete});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Edit)});
            this.bar1.Text = "Tools";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1087, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 626);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1087, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1087, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.cbo_MaNcc);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1087, 115);
            this.panelControl1.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(741, 65);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Huỷ bỏ";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cbo_MaNcc
            // 
            this.cbo_MaNcc.FormattingEnabled = true;
            this.cbo_MaNcc.Location = new System.Drawing.Point(371, 72);
            this.cbo_MaNcc.Name = "cbo_MaNcc";
            this.cbo_MaNcc.Size = new System.Drawing.Size(289, 27);
            this.cbo_MaNcc.TabIndex = 2;
            this.cbo_MaNcc.SelectedIndexChanged += new System.EventHandler(this.cbo_MaNcc_SelectedIndexChanged_1);
            this.cbo_MaNcc.Click += new System.EventHandler(this.cbo_MaNcc_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp";
            // 
            // gc_NhaCungCap
            // 
            this.gc_NhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NhaCungCap.Location = new System.Drawing.Point(0, 149);
            this.gc_NhaCungCap.MainView = this.gv_NhaCungCap;
            this.gc_NhaCungCap.MenuManager = this.barManager1;
            this.gc_NhaCungCap.Name = "gc_NhaCungCap";
            this.gc_NhaCungCap.Size = new System.Drawing.Size(1087, 477);
            this.gc_NhaCungCap.TabIndex = 15;
            this.gc_NhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NhaCungCap});
            // 
            // gv_NhaCungCap
            // 
            this.gv_NhaCungCap.GridControl = this.gc_NhaCungCap;
            this.gv_NhaCungCap.Name = "gv_NhaCungCap";
            this.gv_NhaCungCap.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gv_NhaCungCap_ShowingEditor);
            this.gv_NhaCungCap.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_NhaCungCap_CellValueChanged);
            this.gv_NhaCungCap.DoubleClick += new System.EventHandler(this.gv_NhaCungCap_DoubleClick);
            // 
            // UC_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_NhaCungCap);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_NCC";
            this.Size = new System.Drawing.Size(1087, 626);
            this.Load += new System.EventHandler(this.UC_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private System.Windows.Forms.ComboBox cbo_MaNcc;
        private DevExpress.XtraGrid.GridControl gc_NhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NhaCungCap;
    }
}
