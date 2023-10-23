namespace PetManager
{
    partial class fPetManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácDịchVụChămSócToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ưuĐãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpPet = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.PetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbPet = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(40, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 23);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(171, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 8);
            this.panel6.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.cácDịchVụChămSócToolStripMenuItem,
            this.đồĂnToolStripMenuItem,
            this.ưuĐãiToolStripMenuItem,
            this.hotlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.userToolStripMenuItem.Text = "Admin";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thànhViênToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // thànhViênToolStripMenuItem
            // 
            this.thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thànhViênToolStripMenuItem.Text = "Tài Khoản";
            this.thànhViênToolStripMenuItem.Click += new System.EventHandler(this.thànhViênToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật Thông Tin";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // cácDịchVụChămSócToolStripMenuItem
            // 
            this.cácDịchVụChămSócToolStripMenuItem.Name = "cácDịchVụChămSócToolStripMenuItem";
            this.cácDịchVụChămSócToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.cácDịchVụChămSócToolStripMenuItem.Text = "Các Dịch Vụ Chăm Sóc";
            this.cácDịchVụChămSócToolStripMenuItem.Click += new System.EventHandler(this.cácDịchVụChămSócToolStripMenuItem_Click);
            // 
            // đồĂnToolStripMenuItem
            // 
            this.đồĂnToolStripMenuItem.Name = "đồĂnToolStripMenuItem";
            this.đồĂnToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.đồĂnToolStripMenuItem.Text = "Đồ Ăn";
            // 
            // ưuĐãiToolStripMenuItem
            // 
            this.ưuĐãiToolStripMenuItem.Name = "ưuĐãiToolStripMenuItem";
            this.ưuĐãiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ưuĐãiToolStripMenuItem.Text = "Ưu Đãi";
            // 
            // hotlineToolStripMenuItem
            // 
            this.hotlineToolStripMenuItem.Name = "hotlineToolStripMenuItem";
            this.hotlineToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.hotlineToolStripMenuItem.Text = "Hotline";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 63);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // flpPet
            // 
            this.flpPet.AutoScroll = true;
            this.flpPet.Location = new System.Drawing.Point(25, 108);
            this.flpPet.Name = "flpPet";
            this.flpPet.Size = new System.Drawing.Size(506, 383);
            this.flpPet.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmCount);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.lvBill);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Controls.Add(this.cbPet);
            this.panel3.Location = new System.Drawing.Point(537, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 383);
            this.panel3.TabIndex = 4;
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(224, 56);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(120, 20);
            this.nmCount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(244, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(153, 343);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 37);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh Toan";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(5, 352);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(129, 20);
            this.txtTotalPrice.TabIndex = 2;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PetName,
            this.Count,
            this.Price,
            this.TotalPrice});
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(5, 82);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(356, 255);
            this.lvBill.TabIndex = 1;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // PetName
            // 
            this.PetName.Text = "Thú Cưng";
            this.PetName.Width = 107;
            // 
            // Count
            // 
            this.Count.Text = "Số lượng";
            // 
            // Price
            // 
            this.Price.Text = "Đơn giá";
            this.Price.Width = 77;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Tong Tien";
            this.TotalPrice.Width = 88;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(18, 40);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbPet
            // 
            this.cbPet.FormattingEnabled = true;
            this.cbPet.Location = new System.Drawing.Point(18, 13);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(200, 21);
            this.cbPet.TabIndex = 0;
            // 
            // fPetManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(913, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flpPet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fPetManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí thú cưng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácDịchVụChămSócToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồĂnToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ưuĐãiToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpPet;
        private System.Windows.Forms.ComboBox cbPet;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader PetName;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem hotlineToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmCount;
    }
}