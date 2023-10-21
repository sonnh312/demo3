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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.Pet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thànhViênToolStripMenuItem.Text = "Tài Khoản";
            this.thànhViênToolStripMenuItem.Click += new System.EventHandler(this.thànhViênToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật Thông Tin";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.flpPet.Size = new System.Drawing.Size(598, 383);
            this.flpPet.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.lvBill);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(639, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 383);
            this.panel3.TabIndex = 4;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(153, 343);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 37);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh Toan";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(5, 352);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pet,
            this.Count,
            this.columnHeader1});
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(5, 40);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(242, 297);
            this.lvBill.TabIndex = 1;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // Pet
            // 
            this.Pet.Text = "Thú Cưng";
            // 
            // Count
            // 
            this.Count.Text = "Số lượng";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đơn giá";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader Pet;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ToolStripMenuItem hotlineToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}