namespace AppConnectData
{
    partial class quanLyNganhHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewNH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDNganhHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNganhHoc = new System.Windows.Forms.TextBox();
            this.btnAddNH = new System.Windows.Forms.Button();
            this.btnRepairNH = new System.Windows.Forms.Button();
            this.btnDeleteNH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.btnRepairSV = new System.Windows.Forms.Button();
            this.btnDeleteSV = new System.Windows.Forms.Button();
            this.cbNganhHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAllStudents = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnThemDiem = new System.Windows.Forms.Button();
            this.btnQLDiem = new System.Windows.Forms.Button();
            this.dangxuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNH
            // 
            this.dataGridViewNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNH.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewNH.Name = "dataGridViewNH";
            this.dataGridViewNH.Size = new System.Drawing.Size(373, 297);
            this.dataGridViewNH.TabIndex = 0;
            this.dataGridViewNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNH_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dataGridViewNH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngành Học";
            // 
            // dataGridViewSV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.Size = new System.Drawing.Size(562, 296);
            this.dataGridViewSV.TabIndex = 2;
            this.dataGridViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.dataGridViewSV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Ngành học:";
            // 
            // txtIDNganhHoc
            // 
            this.txtIDNganhHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNganhHoc.Location = new System.Drawing.Point(49, 365);
            this.txtIDNganhHoc.Multiline = true;
            this.txtIDNganhHoc.Name = "txtIDNganhHoc";
            this.txtIDNganhHoc.Size = new System.Drawing.Size(371, 31);
            this.txtIDNganhHoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Ngành học:";
            // 
            // txtTenNganhHoc
            // 
            this.txtTenNganhHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganhHoc.Location = new System.Drawing.Point(49, 421);
            this.txtTenNganhHoc.Multiline = true;
            this.txtTenNganhHoc.Name = "txtTenNganhHoc";
            this.txtTenNganhHoc.Size = new System.Drawing.Size(371, 31);
            this.txtTenNganhHoc.TabIndex = 7;
            // 
            // btnAddNH
            // 
            this.btnAddNH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddNH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNH.Location = new System.Drawing.Point(47, 468);
            this.btnAddNH.Name = "btnAddNH";
            this.btnAddNH.Size = new System.Drawing.Size(75, 35);
            this.btnAddNH.TabIndex = 8;
            this.btnAddNH.Text = "Thêm";
            this.btnAddNH.UseVisualStyleBackColor = false;
            this.btnAddNH.Click += new System.EventHandler(this.btnAddNH_Click);
            // 
            // btnRepairNH
            // 
            this.btnRepairNH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRepairNH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairNH.Location = new System.Drawing.Point(131, 468);
            this.btnRepairNH.Name = "btnRepairNH";
            this.btnRepairNH.Size = new System.Drawing.Size(75, 35);
            this.btnRepairNH.TabIndex = 9;
            this.btnRepairNH.Text = "Sửa";
            this.btnRepairNH.UseVisualStyleBackColor = false;
            this.btnRepairNH.Click += new System.EventHandler(this.btnRepairNH_Click);
            // 
            // btnDeleteNH
            // 
            this.btnDeleteNH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteNH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNH.Location = new System.Drawing.Point(218, 468);
            this.btnDeleteNH.Name = "btnDeleteNH";
            this.btnDeleteNH.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteNH.TabIndex = 10;
            this.btnDeleteNH.Text = "Xóa";
            this.btnDeleteNH.UseVisualStyleBackColor = false;
            this.btnDeleteNH.Click += new System.EventHandler(this.btnDeleteNH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // txtMSV
            // 
            this.txtMSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSV.Location = new System.Drawing.Point(458, 365);
            this.txtMSV.Multiline = true;
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(329, 31);
            this.txtMSV.TabIndex = 12;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(459, 421);
            this.txtTenSV.Multiline = true;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(328, 31);
            this.txtTenSV.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên Sinh Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Ngành Học:";
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddSV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.Location = new System.Drawing.Point(459, 518);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(103, 35);
            this.btnAddSV.TabIndex = 16;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // btnRepairSV
            // 
            this.btnRepairSV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRepairSV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairSV.Location = new System.Drawing.Point(582, 518);
            this.btnRepairSV.Name = "btnRepairSV";
            this.btnRepairSV.Size = new System.Drawing.Size(98, 35);
            this.btnRepairSV.TabIndex = 17;
            this.btnRepairSV.Text = "Sửa";
            this.btnRepairSV.UseVisualStyleBackColor = false;
            this.btnRepairSV.Click += new System.EventHandler(this.btnRepairSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteSV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSV.Location = new System.Drawing.Point(697, 518);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteSV.TabIndex = 18;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.UseVisualStyleBackColor = false;
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // cbNganhHoc
            // 
            this.cbNganhHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNganhHoc.FormattingEnabled = true;
            this.cbNganhHoc.Location = new System.Drawing.Point(459, 481);
            this.cbNganhHoc.Name = "cbNganhHoc";
            this.cbNganhHoc.Size = new System.Drawing.Size(328, 29);
            this.cbNganhHoc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(784, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 21;
            // 
            // btnAllStudents
            // 
            this.btnAllStudents.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAllStudents.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudents.Location = new System.Drawing.Point(812, 365);
            this.btnAllStudents.Name = "btnAllStudents";
            this.btnAllStudents.Size = new System.Drawing.Size(205, 188);
            this.btnAllStudents.TabIndex = 22;
            this.btnAllStudents.Text = "Danh Sách Sinh Viên";
            this.btnAllStudents.UseVisualStyleBackColor = false;
            this.btnAllStudents.Click += new System.EventHandler(this.btnAllStudents_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReset1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Location = new System.Drawing.Point(308, 467);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(112, 35);
            this.btnReset1.TabIndex = 23;
            this.btnReset1.Text = "Xóa Trắng";
            this.btnReset1.UseVisualStyleBackColor = false;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReset2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(458, 562);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(441, 47);
            this.btnReset2.TabIndex = 24;
            this.btnReset2.Text = "Xóa Trắng";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThemDiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDiem.Location = new System.Drawing.Point(234, 520);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(186, 89);
            this.btnThemDiem.TabIndex = 25;
            this.btnThemDiem.Text = "Quản Lí Môn Học";
            this.btnThemDiem.UseVisualStyleBackColor = false;
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // btnQLDiem
            // 
            this.btnQLDiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnQLDiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDiem.Location = new System.Drawing.Point(47, 520);
            this.btnQLDiem.Name = "btnQLDiem";
            this.btnQLDiem.Size = new System.Drawing.Size(181, 89);
            this.btnQLDiem.TabIndex = 26;
            this.btnQLDiem.Text = "Quản Lí Điểm";
            this.btnQLDiem.UseVisualStyleBackColor = false;
            this.btnQLDiem.Click += new System.EventHandler(this.btnQLDiem_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dangxuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuat.Location = new System.Drawing.Point(905, 562);
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(112, 47);
            this.dangxuat.TabIndex = 27;
            this.dangxuat.Text = "Log Out";
            this.dangxuat.UseVisualStyleBackColor = false;
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // quanLyNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 621);
            this.Controls.Add(this.dangxuat);
            this.Controls.Add(this.btnQLDiem);
            this.Controls.Add(this.btnThemDiem);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.btnAllStudents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNganhHoc);
            this.Controls.Add(this.btnDeleteSV);
            this.Controls.Add(this.btnRepairSV);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteNH);
            this.Controls.Add(this.btnRepairNH);
            this.Controls.Add(this.btnAddNH);
            this.Controls.Add(this.txtTenNganhHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDNganhHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "quanLyNganhHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Ngành Học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quanLyNganhHoc_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDNganhHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNganhHoc;
        private System.Windows.Forms.Button btnAddNH;
        private System.Windows.Forms.Button btnRepairNH;
        private System.Windows.Forms.Button btnDeleteNH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.Button btnRepairSV;
        private System.Windows.Forms.Button btnDeleteSV;
        private System.Windows.Forms.ComboBox cbNganhHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAllStudents;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnThemDiem;
        private System.Windows.Forms.Button btnQLDiem;
        private System.Windows.Forms.Button dangxuat;
    }
}

