namespace AppConnectData
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTMH = new System.Windows.Forms.TextBox();
            this.txtSTC = new System.Windows.Forms.TextBox();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaTrangMH = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(507, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học";
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Location = new System.Drawing.Point(10, 26);
            this.dataGridViewMH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.Size = new System.Drawing.Size(489, 231);
            this.dataGridViewMH.TabIndex = 0;
            this.dataGridViewMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMH_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Môn Học:";
            // 
            // txtMMH
            // 
            this.txtMMH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMH.Location = new System.Drawing.Point(30, 317);
            this.txtMMH.Multiline = true;
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(359, 31);
            this.txtMMH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Tín Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Môn Học:";
            // 
            // txtTMH
            // 
            this.txtTMH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMH.Location = new System.Drawing.Point(30, 376);
            this.txtTMH.Multiline = true;
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(359, 31);
            this.txtTMH.TabIndex = 5;
            // 
            // txtSTC
            // 
            this.txtSTC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTC.Location = new System.Drawing.Point(30, 435);
            this.txtSTC.Multiline = true;
            this.txtSTC.Name = "txtSTC";
            this.txtSTC.Size = new System.Drawing.Size(359, 31);
            this.txtSTC.TabIndex = 6;
            // 
            // btnThemMH
            // 
            this.btnThemMH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThemMH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Location = new System.Drawing.Point(403, 308);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(116, 34);
            this.btnThemMH.TabIndex = 7;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = false;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoaMH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(403, 392);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(116, 34);
            this.btnXoaMH.TabIndex = 8;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = false;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuaMH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMH.Location = new System.Drawing.Point(403, 348);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(116, 35);
            this.btnSuaMH.TabIndex = 9;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = false;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnXoaTrangMH
            // 
            this.btnXoaTrangMH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoaTrangMH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTrangMH.Location = new System.Drawing.Point(403, 432);
            this.btnXoaTrangMH.Name = "btnXoaTrangMH";
            this.btnXoaTrangMH.Size = new System.Drawing.Size(116, 35);
            this.btnXoaTrangMH.TabIndex = 10;
            this.btnXoaTrangMH.Text = "Xóa Trắng";
            this.btnXoaTrangMH.UseVisualStyleBackColor = false;
            this.btnXoaTrangMH.Click += new System.EventHandler(this.btnXoaTrangMH_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1062, 654);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 88);
            this.checkedListBox1.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 496);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnXoaTrangMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.txtSTC);
            this.Controls.Add(this.txtTMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Môn Học ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTMH;
        private System.Windows.Forms.TextBox txtSTC;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaTrangMH;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}