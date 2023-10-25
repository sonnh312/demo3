namespace PetManager
{
    partial class fPet
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPetList = new System.Windows.Forms.DataGridView();
            this.txtNamePet = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvPetList);
            this.guna2Panel2.Controls.Add(this.txtNamePet);
            this.guna2Panel2.Controls.Add(this.btnSeach);
            this.guna2Panel2.Location = new System.Drawing.Point(22, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(615, 314);
            this.guna2Panel2.TabIndex = 13;
            // 
            // dgvPetList
            // 
            this.dgvPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetList.Location = new System.Drawing.Point(20, 92);
            this.dgvPetList.Name = "dgvPetList";
            this.dgvPetList.Size = new System.Drawing.Size(559, 208);
            this.dgvPetList.TabIndex = 4;
            // 
            // txtNamePet
            // 
            this.txtNamePet.Location = new System.Drawing.Point(20, 66);
            this.txtNamePet.Name = "txtNamePet";
            this.txtNamePet.Size = new System.Drawing.Size(243, 20);
            this.txtNamePet.TabIndex = 2;
            // 
            // btnSeach
            // 
            this.btnSeach.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(269, 63);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(64, 23);
            this.btnSeach.TabIndex = 10;
            this.btnSeach.Text = "Tìm";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // fPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 346);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "fPet";
            this.Text = "fPet";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dgvPetList;
        private System.Windows.Forms.TextBox txtNamePet;
        private System.Windows.Forms.Button btnSeach;
    }
}