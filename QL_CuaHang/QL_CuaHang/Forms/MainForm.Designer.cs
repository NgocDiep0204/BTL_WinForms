namespace QL_CuaHang
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.ac_Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
			this.ce_DanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_SanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_KhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_Sales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_NhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_Loai = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.ce_QuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_DoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_NhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_NCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.ce_HeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_ThongTinTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btn_DangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.bh_TieuDe = new DevExpress.XtraBars.BarHeaderItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.text_Account = new DevExpress.XtraBars.BarButtonItem();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ac_Menu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainContainer
			// 
			this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainContainer.Location = new System.Drawing.Point(501, 39);
			this.mainContainer.Name = "mainContainer";
			this.mainContainer.Size = new System.Drawing.Size(501, 506);
			this.mainContainer.TabIndex = 0;
			// 
			// ac_Menu
			// 
			this.ac_Menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.ac_Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.ce_DanhMuc,
            this.ce_QuanLy,
            this.ce_HeThong});
			this.ac_Menu.Location = new System.Drawing.Point(0, 39);
			this.ac_Menu.Margin = new System.Windows.Forms.Padding(6);
			this.ac_Menu.Name = "ac_Menu";
			this.ac_Menu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.ac_Menu.Size = new System.Drawing.Size(501, 506);
			this.ac_Menu.TabIndex = 1;
			this.ac_Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlSeparator1
			// 
			this.accordionControlSeparator1.Name = "accordionControlSeparator1";
			// 
			// ce_DanhMuc
			// 
			this.ce_DanhMuc.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.ce_DanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_SanPham,
            this.btn_KhachHang,
            this.btn_Sales,
            this.btn_NhapHang,
            this.btn_Loai});
			this.ce_DanhMuc.Expanded = true;
			this.ce_DanhMuc.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
			this.ce_DanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ce_DanhMuc.ImageOptions.Image")));
			this.ce_DanhMuc.Name = "ce_DanhMuc";
			this.ce_DanhMuc.Text = "Danh Mục";
			// 
			// btn_SanPham
			// 
			this.btn_SanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SanPham.ImageOptions.Image")));
			this.btn_SanPham.Name = "btn_SanPham";
			this.btn_SanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_SanPham.Text = "Sản Phẩm";
			this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
			// 
			// btn_KhachHang
			// 
			this.btn_KhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.ImageOptions.Image")));
			this.btn_KhachHang.Name = "btn_KhachHang";
			this.btn_KhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_KhachHang.Text = "Khách Hàng";
			this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
			// 
			// btn_Sales
			// 
			this.btn_Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sales.ImageOptions.Image")));
			this.btn_Sales.Name = "btn_Sales";
			this.btn_Sales.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_Sales.Text = "Bán Hàng";
			this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
			// 
			// btn_NhapHang
			// 
			this.btn_NhapHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapHang.ImageOptions.Image")));
			this.btn_NhapHang.Name = "btn_NhapHang";
			this.btn_NhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_NhapHang.Text = "Nhập Hàng";
			this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
			// 
			// btn_Loai
			// 
			this.btn_Loai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Loai.ImageOptions.Image")));
			this.btn_Loai.Name = "btn_Loai";
			this.btn_Loai.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_Loai.Text = "Loại ";
			this.btn_Loai.Click += new System.EventHandler(this.btn_Loai_Click);
			// 
			// ce_QuanLy
			// 
			this.ce_QuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_DoanhThu,
            this.btn_NhanVien,
            this.btn_NCC});
			this.ce_QuanLy.Expanded = true;
			this.ce_QuanLy.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
			this.ce_QuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ce_QuanLy.ImageOptions.Image")));
			this.ce_QuanLy.Name = "ce_QuanLy";
			this.ce_QuanLy.Text = "Quản Lý";
			// 
			// btn_DoanhThu
			// 
			this.btn_DoanhThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoanhThu.ImageOptions.Image")));
			this.btn_DoanhThu.Name = "btn_DoanhThu";
			this.btn_DoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_DoanhThu.Text = "Doanh Thu";
			this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
			// 
			// btn_NhanVien
			// 
			this.btn_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.Image")));
			this.btn_NhanVien.Name = "btn_NhanVien";
			this.btn_NhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_NhanVien.Text = "Nhân Viên";
			this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
			// 
			// btn_NCC
			// 
			this.btn_NCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NCC.ImageOptions.Image")));
			this.btn_NCC.Name = "btn_NCC";
			this.btn_NCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_NCC.Text = "Nhà Cung Cấp";
			this.btn_NCC.Click += new System.EventHandler(this.btn_Ncc_Click);
			// 
			// ce_HeThong
			// 
			this.ce_HeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_ThongTinTK,
            this.btn_DangXuat});
			this.ce_HeThong.Expanded = true;
			this.ce_HeThong.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
			this.ce_HeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ce_HeThong.ImageOptions.Image")));
			this.ce_HeThong.Name = "ce_HeThong";
			this.ce_HeThong.Text = "Hệ Thống";
			// 
			// btn_ThongTinTK
			// 
			this.btn_ThongTinTK.Name = "btn_ThongTinTK";
			this.btn_ThongTinTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_ThongTinTK.Text = "Thông Tin TK";
			// 
			// btn_DangXuat
			// 
			this.btn_DangXuat.Name = "btn_DangXuat";
			this.btn_DangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.btn_DangXuat.Text = "Đăng Xuất";
			this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bh_TieuDe,
            this.barSubItem1,
            this.barHeaderItem1,
            this.text_Account});
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(1002, 39);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.bh_TieuDe);
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.barSubItem1);
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.text_Account);
			// 
			// bh_TieuDe
			// 
			this.bh_TieuDe.Caption = "Welcome";
			this.bh_TieuDe.Id = 0;
			this.bh_TieuDe.Name = "bh_TieuDe";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Id = 1;
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barHeaderItem1
			// 
			this.barHeaderItem1.Caption = "Account";
			this.barHeaderItem1.Id = 2;
			this.barHeaderItem1.Name = "barHeaderItem1";
			// 
			// text_Account
			// 
			this.text_Account.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.text_Account.Caption = "Account";
			this.text_Account.Id = 3;
			this.text_Account.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("text_Account.ImageOptions.SvgImage")));
			this.text_Account.Name = "text_Account";
			this.text_Account.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.Form = this;
			this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bh_TieuDe,
            this.barSubItem1,
            this.barHeaderItem1,
            this.text_Account});
			this.fluentFormDefaultManager1.MaxItemId = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 545);
			this.ControlContainer = this.mainContainer;
			this.Controls.Add(this.mainContainer);
			this.Controls.Add(this.ac_Menu);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Name = "MainForm";
			this.NavigationControl = this.ac_Menu;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laptop24H";
			((System.ComponentModel.ISupportInitialize)(this.ac_Menu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
		private DevExpress.XtraBars.Navigation.AccordionControl ac_Menu;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ce_DanhMuc;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_SanPham;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_NhanVien;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_DoanhThu;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ce_HeThong;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_DangXuat;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ThongTinTK;
		private DevExpress.XtraBars.BarHeaderItem bh_TieuDe;
		private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_KhachHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_NhapHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Sales;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ce_QuanLy;
		private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
		private DevExpress.XtraBars.BarButtonItem text_Account;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_NCC;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Loai;
	}
}
