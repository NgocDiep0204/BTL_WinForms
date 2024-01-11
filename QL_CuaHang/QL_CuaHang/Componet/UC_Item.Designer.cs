namespace QL_CuaHang.Componet
{
    partial class UC_Item
    {
        //public Load_UcControl formLoadControll = new Load_UcControl();
        public DataBase dtBase = new DataBase();
        public EditValueFunction edit = new EditValueFunction();
        public DeleteValueFunction delete = new DeleteValueFunction();
        private bool _checkDeleteFunction = false;
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
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_ItemPrice = new System.Windows.Forms.Label();
            this.imgItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Location = new System.Drawing.Point(3, 145);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(42, 20);
            this.lbl_ItemName.TabIndex = 1;
            this.lbl_ItemName.Text = "label";
            // 
            // lbl_ItemPrice
            // 
            this.lbl_ItemPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ItemPrice.AutoSize = true;
            this.lbl_ItemPrice.Location = new System.Drawing.Point(135, 157);
            this.lbl_ItemPrice.Name = "lbl_ItemPrice";
            this.lbl_ItemPrice.Size = new System.Drawing.Size(51, 20);
            this.lbl_ItemPrice.TabIndex = 2;
            this.lbl_ItemPrice.Text = "label2";
            // 
            // imgItem
            // 
            this.imgItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgItem.Location = new System.Drawing.Point(0, 0);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(200, 132);
            this.imgItem.TabIndex = 3;
            this.imgItem.TabStop = false;
            // 
            // UC_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.imgItem);
            this.Controls.Add(this.lbl_ItemPrice);
            this.Controls.Add(this.lbl_ItemName);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(200, 186);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_ItemPrice;
        private System.Windows.Forms.PictureBox imgItem;
    }
}
