
namespace Book_Shop_Management_System
{
    partial class Books
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbUS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.btnUEdit = new System.Windows.Forms.Button();
            this.btnUDelete = new System.Windows.Forms.Button();
            this.btnUReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnUSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefresh.Location = new System.Drawing.Point(864, 360);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 39);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbUS
            // 
            this.cmbUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUS.FormattingEnabled = true;
            this.cmbUS.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "English",
            "Bangla",
            "BGS",
            "Biology",
            "DataBase"});
            this.cmbUS.Location = new System.Drawing.Point(612, 360);
            this.cmbUS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUS.Name = "cmbUS";
            this.cmbUS.Size = new System.Drawing.Size(223, 31);
            this.cmbUS.TabIndex = 55;
            this.cmbUS.SelectedIndexChanged += new System.EventHandler(this.cmbUS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(659, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 46);
            this.label2.TabIndex = 54;
            this.label2.Text = "Book List";
            // 
            // BookDGV
            // 
            this.BookDGV.AllowUserToAddRows = false;
            this.BookDGV.AllowUserToDeleteRows = false;
            this.BookDGV.BackgroundColor = System.Drawing.Color.White;
            this.BookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BookDGV.Location = new System.Drawing.Point(227, 415);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(1096, 384);
            this.BookDGV.TabIndex = 53;
            // 
            // btnUEdit
            // 
            this.btnUEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUEdit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUEdit.Location = new System.Drawing.Point(608, 202);
            this.btnUEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnUEdit.Name = "btnUEdit";
            this.btnUEdit.Size = new System.Drawing.Size(117, 46);
            this.btnUEdit.TabIndex = 52;
            this.btnUEdit.Text = "Edit";
            this.btnUEdit.UseVisualStyleBackColor = true;
            this.btnUEdit.Click += new System.EventHandler(this.btnUEdit_Click);
            // 
            // btnUDelete
            // 
            this.btnUDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUDelete.Location = new System.Drawing.Point(766, 202);
            this.btnUDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnUDelete.Name = "btnUDelete";
            this.btnUDelete.Size = new System.Drawing.Size(117, 46);
            this.btnUDelete.TabIndex = 51;
            this.btnUDelete.Text = "Delete";
            this.btnUDelete.UseVisualStyleBackColor = true;
            this.btnUDelete.Click += new System.EventHandler(this.btnUDelete_Click);
            // 
            // btnUReset
            // 
            this.btnUReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUReset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUReset.Location = new System.Drawing.Point(935, 202);
            this.btnUReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnUReset.Name = "btnUReset";
            this.btnUReset.Size = new System.Drawing.Size(117, 46);
            this.btnUReset.TabIndex = 50;
            this.btnUReset.Text = "Reset";
            this.btnUReset.UseVisualStyleBackColor = true;
            this.btnUReset.Click += new System.EventHandler(this.btnUReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1111, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 30);
            this.label9.TabIndex = 49;
            this.label9.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1116, 141);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(189, 32);
            this.txtPrice.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(934, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 47;
            this.label7.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(939, 141);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(168, 32);
            this.txtQuantity.TabIndex = 46;
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "English",
            "Bangla",
            "BGS",
            "Biology",
            "DataBase",
            "Novel"});
            this.cmbCat.Location = new System.Drawing.Point(695, 139);
            this.cmbCat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(223, 31);
            this.cmbCat.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(690, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "Categories";
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
            // btnBL
            // 
            this.btnBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBL.Location = new System.Drawing.Point(35, 350);
            this.btnBL.Margin = new System.Windows.Forms.Padding(4);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(151, 46);
            this.btnBL.TabIndex = 25;
            this.btnBL.Text = "Logout";
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
            // 
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBD.Location = new System.Drawing.Point(35, 262);
            this.btnBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(151, 46);
            this.btnBD.TabIndex = 24;
            this.btnBD.Text = "DashBoard";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUser.Location = new System.Drawing.Point(35, 167);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(151, 46);
            this.btnUser.TabIndex = 23;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnUSave
            // 
            this.btnUSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUSave.Location = new System.Drawing.Point(450, 202);
            this.btnUSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnUSave.Name = "btnUSave";
            this.btnUSave.Size = new System.Drawing.Size(117, 46);
            this.btnUSave.TabIndex = 42;
            this.btnUSave.Text = "Save";
            this.btnUSave.UseVisualStyleBackColor = true;
            this.btnUSave.Click += new System.EventHandler(this.btnUSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 40;
            this.label3.Text = "Book Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(456, 141);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(217, 32);
            this.txtAuthor.TabIndex = 39;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(236, 141);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(197, 32);
            this.txtBookTitle.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(467, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "BookShop Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBL);
            this.panel1.Controls.Add(this.btnBD);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 798);
            this.panel1.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label8.Location = new System.Drawing.Point(1284, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 41);
            this.label8.TabIndex = 43;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 798);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookDGV);
            this.Controls.Add(this.btnUEdit);
            this.Controls.Add(this.btnUDelete);
            this.Controls.Add(this.btnUReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbUS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Button btnUEdit;
        private System.Windows.Forms.Button btnUDelete;
        private System.Windows.Forms.Button btnUReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnUSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}