
namespace Book_Shop_Management_System
{
    partial class Dashboard
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
            this.btnDBooks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDLogout = new System.Windows.Forms.Button();
            this.btnDUsers = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalBooks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Totaluser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDBooks
            // 
            this.btnDBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBooks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDBooks.Location = new System.Drawing.Point(43, 175);
            this.btnDBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnDBooks.Name = "btnDBooks";
            this.btnDBooks.Size = new System.Drawing.Size(151, 46);
            this.btnDBooks.TabIndex = 22;
            this.btnDBooks.Text = "Books";
            this.btnDBooks.UseVisualStyleBackColor = true;
            this.btnDBooks.Click += new System.EventHandler(this.btnDBooks_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDLogout);
            this.panel1.Controls.Add(this.btnDUsers);
            this.panel1.Controls.Add(this.btnDBooks);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 798);
            this.panel1.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "BookShop";
            // 
            // btnDLogout
            // 
            this.btnDLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDLogout.Location = new System.Drawing.Point(43, 350);
            this.btnDLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnDLogout.Name = "btnDLogout";
            this.btnDLogout.Size = new System.Drawing.Size(151, 46);
            this.btnDLogout.TabIndex = 25;
            this.btnDLogout.Text = "Logout";
            this.btnDLogout.UseVisualStyleBackColor = true;
            this.btnDLogout.Click += new System.EventHandler(this.btnDLogout_Click);
            // 
            // btnDUsers
            // 
            this.btnDUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDUsers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDUsers.Location = new System.Drawing.Point(43, 261);
            this.btnDUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnDUsers.Name = "btnDUsers";
            this.btnDUsers.Size = new System.Drawing.Size(151, 46);
            this.btnDUsers.TabIndex = 24;
            this.btnDUsers.Text = "Users";
            this.btnDUsers.UseVisualStyleBackColor = true;
            this.btnDUsers.Click += new System.EventHandler(this.btnDUsers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label8.Location = new System.Drawing.Point(1286, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 41);
            this.label8.TabIndex = 67;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.TotalBooks);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(378, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 160);
            this.panel2.TabIndex = 64;
            // 
            // TotalBooks
            // 
            this.TotalBooks.AutoSize = true;
            this.TotalBooks.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBooks.ForeColor = System.Drawing.Color.White;
            this.TotalBooks.Location = new System.Drawing.Point(73, 74);
            this.TotalBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalBooks.Name = "TotalBooks";
            this.TotalBooks.Size = new System.Drawing.Size(41, 44);
            this.TotalBooks.TabIndex = 23;
            this.TotalBooks.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Books";
            // 
            // Totaluser
            // 
            this.Totaluser.AutoSize = true;
            this.Totaluser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaluser.ForeColor = System.Drawing.Color.White;
            this.Totaluser.Location = new System.Drawing.Point(87, 74);
            this.Totaluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Totaluser.Name = "Totaluser";
            this.Totaluser.Size = new System.Drawing.Size(41, 44);
            this.Totaluser.TabIndex = 23;
            this.Totaluser.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.Totaluser);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(823, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 160);
            this.panel3.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(469, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 50);
            this.label1.TabIndex = 65;
            this.label1.Text = "BookShop Management System";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 798);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDLogout;
        private System.Windows.Forms.Button btnDUsers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Totaluser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}