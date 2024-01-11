namespace QL_CuaHang
{
    partial class Login
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
			this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_DangNhap = new System.Windows.Forms.Button();
			this.cb_LuuMK = new System.Windows.Forms.CheckBox();
			this.lb_TaoTK = new System.Windows.Forms.LinkLabel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.SuspendLayout();
			// 
			// txt_TaiKhoan
			// 
			this.txt_TaiKhoan.Location = new System.Drawing.Point(129, 38);
			this.txt_TaiKhoan.Name = "txt_TaiKhoan";
			this.txt_TaiKhoan.Size = new System.Drawing.Size(176, 22);
			this.txt_TaiKhoan.TabIndex = 0;
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.Location = new System.Drawing.Point(129, 82);
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.PasswordChar = '*';
			this.txt_MatKhau.Size = new System.Drawing.Size(176, 22);
			this.txt_MatKhau.TabIndex = 1;
			this.txt_MatKhau.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tài Khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật Khẩu";
			// 
			// btn_DangNhap
			// 
			this.btn_DangNhap.Location = new System.Drawing.Point(129, 154);
			this.btn_DangNhap.Name = "btn_DangNhap";
			this.btn_DangNhap.Size = new System.Drawing.Size(110, 41);
			this.btn_DangNhap.TabIndex = 3;
			this.btn_DangNhap.Text = "Đăng Nhập";
			this.btn_DangNhap.UseVisualStyleBackColor = true;
			this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
			// 
			// cb_LuuMK
			// 
			this.cb_LuuMK.AutoSize = true;
			this.cb_LuuMK.Location = new System.Drawing.Point(62, 117);
			this.cb_LuuMK.Name = "cb_LuuMK";
			this.cb_LuuMK.Size = new System.Drawing.Size(75, 20);
			this.cb_LuuMK.TabIndex = 5;
			this.cb_LuuMK.Text = "Nhớ mk";
			this.cb_LuuMK.UseVisualStyleBackColor = true;
			// 
			// lb_TaoTK
			// 
			this.lb_TaoTK.AutoSize = true;
			this.lb_TaoTK.Location = new System.Drawing.Point(244, 117);
			this.lb_TaoTK.Name = "lb_TaoTK";
			this.lb_TaoTK.Size = new System.Drawing.Size(89, 16);
			this.lb_TaoTK.TabIndex = 6;
			this.lb_TaoTK.TabStop = true;
			this.lb_TaoTK.Text = "Tạo tài khoản";
			this.lb_TaoTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_TaoTK_LinkClicked);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(156, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(60, 16);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "Laptop24H";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 224);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.lb_TaoTK);
			this.Controls.Add(this.cb_LuuMK);
			this.Controls.Add(this.btn_DangNhap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.txt_TaiKhoan);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LapTop24H";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DangNhap;
		private System.Windows.Forms.CheckBox cb_LuuMK;
		private System.Windows.Forms.LinkLabel lb_TaoTK;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}

