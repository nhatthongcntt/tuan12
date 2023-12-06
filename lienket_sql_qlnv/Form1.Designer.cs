namespace lienket_sql_qlnv
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_td_qlnv = new System.Windows.Forms.Label();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_tailai = new System.Windows.Forms.Button();
            this.textBox_idnv = new System.Windows.Forms.TextBox();
            this.textBox_tennv = new System.Windows.Forms.TextBox();
            this.textBox_luongnv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label_td_qlnv
            // 
            this.label_td_qlnv.AutoSize = true;
            this.label_td_qlnv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_td_qlnv.ForeColor = System.Drawing.Color.Red;
            this.label_td_qlnv.Location = new System.Drawing.Point(325, 9);
            this.label_td_qlnv.Name = "label_td_qlnv";
            this.label_td_qlnv.Size = new System.Drawing.Size(237, 32);
            this.label_td_qlnv.TabIndex = 3;
            this.label_td_qlnv.Text = "Quản lý nhân viên";
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(751, 209);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(85, 41);
            this.button_them.TabIndex = 3;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(751, 394);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(85, 41);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(751, 302);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(85, 41);
            this.button_sua.TabIndex = 4;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 318);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_tailai
            // 
            this.button_tailai.Location = new System.Drawing.Point(751, 486);
            this.button_tailai.Name = "button_tailai";
            this.button_tailai.Size = new System.Drawing.Size(85, 41);
            this.button_tailai.TabIndex = 6;
            this.button_tailai.Text = "Tải lại";
            this.button_tailai.UseVisualStyleBackColor = true;
            this.button_tailai.Click += new System.EventHandler(this.button_tailai_Click);
            // 
            // textBox_idnv
            // 
            this.textBox_idnv.Location = new System.Drawing.Point(154, 70);
            this.textBox_idnv.Name = "textBox_idnv";
            this.textBox_idnv.ReadOnly = true;
            this.textBox_idnv.Size = new System.Drawing.Size(247, 22);
            this.textBox_idnv.TabIndex = 12;
            // 
            // textBox_tennv
            // 
            this.textBox_tennv.Location = new System.Drawing.Point(154, 118);
            this.textBox_tennv.Name = "textBox_tennv";
            this.textBox_tennv.Size = new System.Drawing.Size(247, 22);
            this.textBox_tennv.TabIndex = 1;
            // 
            // textBox_luongnv
            // 
            this.textBox_luongnv.Location = new System.Drawing.Point(154, 164);
            this.textBox_luongnv.Name = "textBox_luongnv";
            this.textBox_luongnv.Size = new System.Drawing.Size(247, 22);
            this.textBox_luongnv.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.textBox_luongnv);
            this.Controls.Add(this.textBox_tennv);
            this.Controls.Add(this.textBox_idnv);
            this.Controls.Add(this.button_tailai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.label_td_qlnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_td_qlnv;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_tailai;
        private System.Windows.Forms.TextBox textBox_idnv;
        private System.Windows.Forms.TextBox textBox_tennv;
        private System.Windows.Forms.TextBox textBox_luongnv;
    }
}

