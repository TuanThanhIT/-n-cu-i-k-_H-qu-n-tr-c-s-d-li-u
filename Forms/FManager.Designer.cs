﻿namespace DemoCSDL.Forms
{
    partial class FManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManager));
            this.panelTop = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSideBar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCheBien = new Guna.UI2.WinForms.Guna2Button();
            this.btnPM = new Guna.UI2.WinForms.Guna2Button();
            this.btnMBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnShift = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            panelFill = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.panelTop.Controls.Add(this.guna2Panel1);
            this.panelTop.Controls.Add(this.btnSideBar);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.guna2TextBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1500, 59);
            this.panelTop.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 56);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1500, 3);
            this.guna2Panel1.TabIndex = 9;
            // 
            // btnSideBar
            // 
            this.btnSideBar.FillColor = System.Drawing.Color.Transparent;
            this.btnSideBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSideBar.ForeColor = System.Drawing.Color.White;
            this.btnSideBar.Image = global::DemoCSDL.Properties.Resources.menuImage;
            this.btnSideBar.Location = new System.Drawing.Point(12, 3);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSideBar.Size = new System.Drawing.Size(48, 47);
            this.btnSideBar.TabIndex = 8;
            this.btnSideBar.Click += new System.EventHandler(this.btnSideBar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
            this.btnClose.Location = new System.Drawing.Point(1437, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = global::DemoCSDL.Properties.Resources.iconsearch;
            this.guna2TextBox1.Location = new System.Drawing.Point(536, 13);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox1.PlaceholderText = "Search";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(670, 35);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.panelLeft.Controls.Add(this.btnCheBien);
            this.panelLeft.Controls.Add(this.btnPM);
            this.panelLeft.Controls.Add(this.btnMBill);
            this.panelLeft.Controls.Add(this.guna2Button1);
            this.panelLeft.Controls.Add(this.btnShift);
            this.panelLeft.Controls.Add(this.btnAddProduct);
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.btnUser);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 59);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 741);
            this.panelLeft.TabIndex = 6;
            this.panelLeft.Visible = false;
            // 
            // btnCheBien
            // 
            this.btnCheBien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnCheBien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheBien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnCheBien.Location = new System.Drawing.Point(0, 477);
            this.btnCheBien.Name = "btnCheBien";
            this.btnCheBien.Size = new System.Drawing.Size(250, 63);
            this.btnCheBien.TabIndex = 8;
            this.btnCheBien.Text = "Quản Lý Nguyên Liệu";
            this.btnCheBien.Click += new System.EventHandler(this.btnCheBien_Click);
            // 
            // btnPM
            // 
            this.btnPM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnPM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnPM.Location = new System.Drawing.Point(0, 408);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(250, 63);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "Quản Lý Nhân Sự";
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnMBill
            // 
            this.btnMBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnMBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnMBill.Location = new System.Drawing.Point(0, 339);
            this.btnMBill.Name = "btnMBill";
            this.btnMBill.Size = new System.Drawing.Size(250, 63);
            this.btnMBill.TabIndex = 6;
            this.btnMBill.Text = "Quản Lý Hóa Đơn";
            this.btnMBill.Click += new System.EventHandler(this.btnMBill_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.guna2Button1.Location = new System.Drawing.Point(0, 207);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(250, 63);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Quản Lý Kho";
            this.guna2Button1.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnShift
            // 
            this.btnShift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnShift.Location = new System.Drawing.Point(0, 276);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(250, 63);
            this.btnShift.TabIndex = 4;
            this.btnShift.Text = "Quản Lý Ca Làm";
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 138);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 63);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Quản Lý Sản Phẩm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 675);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(250, 63);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnUser
            // 
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnUser.Location = new System.Drawing.Point(0, 69);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(250, 63);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Chỉnh Sửa Thông Tin";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(250, 63);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Trang Tổng Quan";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelFill
            // 
            panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFill.Location = new System.Drawing.Point(250, 59);
            panelFill.Name = "panelFill";
            panelFill.Size = new System.Drawing.Size(1250, 741);
            panelFill.TabIndex = 7;
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(panelFill);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSideBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnShift;
        private Guna.UI2.WinForms.Guna2Button btnMBill;
        private Guna.UI2.WinForms.Guna2Button btnPM;
        private Guna.UI2.WinForms.Guna2Button btnCheBien;
        public static System.Windows.Forms.Panel panelFill;
    }
}