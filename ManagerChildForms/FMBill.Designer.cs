﻿namespace DemoCSDL.ManagerChildForms
{
    partial class FMBill
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
            this.gvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaHD = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnChitietHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.gvChiTietHD = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDSHoaDon
            // 
            this.gvDSHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.gvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSHoaDon.Location = new System.Drawing.Point(2, 375);
            this.gvDSHoaDon.Name = "gvDSHoaDon";
            this.gvDSHoaDon.RowHeadersWidth = 51;
            this.gvDSHoaDon.RowTemplate.Height = 24;
            this.gvDSHoaDon.Size = new System.Drawing.Size(669, 353);
            this.gvDSHoaDon.TabIndex = 0;
            this.gvDSHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSHoaDon_CellClick);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(587, 48);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(219, 27);
            this.cmbNhanVien.TabIndex = 2;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBegin.Location = new System.Drawing.Point(146, 48);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(264, 27);
            this.dateTimeBegin.TabIndex = 3;
            this.dateTimeBegin.Value = new System.DateTime(2024, 11, 5, 0, 0, 0, 0);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Location = new System.Drawing.Point(146, 96);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(264, 27);
            this.dateTimeEnd.TabIndex = 4;
            this.dateTimeEnd.Value = new System.DateTime(2024, 11, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BorderRadius = 1;
            this.btnXoaHD.BorderThickness = 1;
            this.btnXoaHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHD.FillColor = System.Drawing.Color.White;
            this.btnXoaHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnXoaHD.Location = new System.Drawing.Point(982, 227);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(122, 30);
            this.btnXoaHD.TabIndex = 8;
            this.btnXoaHD.Text = "Xóa HD";
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(492, 230);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(154, 22);
            this.txtSoNgay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bạn muốn giữ lại hóa đơn trong phạm vi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã HD:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(207, 284);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(154, 22);
            this.txtMaHD.TabIndex = 13;
            // 
            // btnChitietHD
            // 
            this.btnChitietHD.BorderRadius = 1;
            this.btnChitietHD.BorderThickness = 1;
            this.btnChitietHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChitietHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChitietHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChitietHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChitietHD.FillColor = System.Drawing.Color.White;
            this.btnChitietHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnChitietHD.Location = new System.Drawing.Point(981, 276);
            this.btnChitietHD.Name = "btnChitietHD";
            this.btnChitietHD.Size = new System.Drawing.Size(122, 30);
            this.btnChitietHD.TabIndex = 14;
            this.btnChitietHD.Text = "Chi tiết HD";
            this.btnChitietHD.Click += new System.EventHandler(this.btnChitietHD_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BorderRadius = 1;
            this.btnTimkiem.BorderThickness = 1;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnTimkiem.Location = new System.Drawing.Point(857, 48);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(122, 30);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // gvChiTietHD
            // 
            this.gvChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.gvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChiTietHD.Location = new System.Drawing.Point(677, 375);
            this.gvChiTietHD.Name = "gvChiTietHD";
            this.gvChiTietHD.RowHeadersWidth = 51;
            this.gvChiTietHD.RowTemplate.Height = 24;
            this.gvChiTietHD.Size = new System.Drawing.Size(564, 353);
            this.gvChiTietHD.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Danh sách hóa đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(681, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chi tiết hóa đơn:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(436, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(319, 52);
            this.guna2HtmlLabel1.TabIndex = 19;
            this.guna2HtmlLabel1.Text = "Quản lý hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeBegin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNhanVien);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 136);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm hóa đơn";
            // 
            // FMBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1244, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gvChiTietHD);
            this.Controls.Add(this.btnChitietHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.gvDSHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMBill";
            this.Load += new System.EventHandler(this.FMBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDSHoaDon;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnXoaHD;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2Button btnChitietHD;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.DataGridView gvChiTietHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}