﻿namespace sidebartest
{
    partial class FormQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_VaiTro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_vohieuhoa = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_mota = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_maNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TinhTrang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_xacNhanMK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_MK = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_maNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_XacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_tenNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_tenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_VaiTro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_nhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_MK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_GioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdo_Nam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_Nu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.BorderRadius = 5;
            this.btn_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Refresh.Font = new System.Drawing.Font("SVN-Cintra", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1411, 823);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(201, 43);
            this.btn_Refresh.TabIndex = 25;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // cbo_VaiTro
            // 
            this.cbo_VaiTro.BackColor = System.Drawing.Color.Transparent;
            this.cbo_VaiTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_VaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_VaiTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_VaiTro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_VaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_VaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_VaiTro.ItemHeight = 30;
            this.cbo_VaiTro.Location = new System.Drawing.Point(34, 286);
            this.cbo_VaiTro.Name = "cbo_VaiTro";
            this.cbo_VaiTro.Size = new System.Drawing.Size(525, 36);
            this.cbo_VaiTro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbo_VaiTro.TabIndex = 24;
            this.cbo_VaiTro.SelectedIndexChanged += new System.EventHandler(this.cbo_VaiTro_SelectedIndexChanged);
            // 
            // btn_vohieuhoa
            // 
            this.btn_vohieuhoa.BackColor = System.Drawing.Color.White;
            this.btn_vohieuhoa.BorderRadius = 5;
            this.btn_vohieuhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_vohieuhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_vohieuhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_vohieuhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_vohieuhoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_vohieuhoa.Font = new System.Drawing.Font("SVN-Cintra", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vohieuhoa.ForeColor = System.Drawing.Color.White;
            this.btn_vohieuhoa.Location = new System.Drawing.Point(1217, 823);
            this.btn_vohieuhoa.Name = "btn_vohieuhoa";
            this.btn_vohieuhoa.Size = new System.Drawing.Size(188, 43);
            this.btn_vohieuhoa.TabIndex = 14;
            this.btn_vohieuhoa.Text = "Vô hiệu hóa";
            this.btn_vohieuhoa.Click += new System.EventHandler(this.btn_vohieuhoa_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(771, 447);
            this.txt_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_search.PlaceholderText = "Search...";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(255, 44);
            this.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_search.TabIndex = 15;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.White;
            this.btn_sua.BorderRadius = 5;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sua.Font = new System.Drawing.Font("SVN-Cintra", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(1087, 823);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(124, 43);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.AutoSize = true;
            this.txt_TinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TinhTrang.DefaultText = "";
            this.txt_TinhTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TinhTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TinhTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TinhTrang.Location = new System.Drawing.Point(1087, 367);
            this.txt_TinhTrang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.PasswordChar = '\0';
            this.txt_TinhTrang.PlaceholderText = "";
            this.txt_TinhTrang.SelectedText = "";
            this.txt_TinhTrang.Size = new System.Drawing.Size(522, 45);
            this.txt_TinhTrang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TinhTrang.TabIndex = 23;
            this.txt_TinhTrang.TextChanged += new System.EventHandler(this.txt_TinhTrang_TextChanged);
            // 
            // lbl_mota
            // 
            this.lbl_mota.BackColor = System.Drawing.Color.White;
            this.lbl_mota.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mota.Location = new System.Drawing.Point(1087, 421);
            this.lbl_mota.Name = "lbl_mota";
            this.lbl_mota.Size = new System.Drawing.Size(75, 36);
            this.lbl_mota.TabIndex = 8;
            this.lbl_mota.Text = "Địa chỉ";
            this.lbl_mota.Click += new System.EventHandler(this.lbl_mota_Click);
            // 
            // txt_maNV
            // 
            this.txt_maNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maNV.DefaultText = "";
            this.txt_maNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNV.Location = new System.Drawing.Point(34, 91);
            this.txt_maNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.PasswordChar = '\0';
            this.txt_maNV.PlaceholderText = "";
            this.txt_maNV.SelectedText = "";
            this.txt_maNV.Size = new System.Drawing.Size(525, 45);
            this.txt_maNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_maNV.TabIndex = 2;
            this.txt_maNV.TextChanged += new System.EventHandler(this.txt_maNV_TextChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.DefaultText = "";
            this.txt_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(1087, 464);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(525, 350);
            this.txt_DiaChi.TabIndex = 10;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.BackColor = System.Drawing.Color.White;
            this.lbl_TinhTrang.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TinhTrang.Location = new System.Drawing.Point(1087, 322);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(109, 36);
            this.lbl_TinhTrang.TabIndex = 22;
            this.lbl_TinhTrang.Text = "Tình trạng";
            this.lbl_TinhTrang.Click += new System.EventHandler(this.lbl_TinhTrang_Click);
            // 
            // lbl_xacNhanMK
            // 
            this.lbl_xacNhanMK.BackColor = System.Drawing.Color.White;
            this.lbl_xacNhanMK.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xacNhanMK.Location = new System.Drawing.Point(1087, 223);
            this.lbl_xacNhanMK.Name = "lbl_xacNhanMK";
            this.lbl_xacNhanMK.Size = new System.Drawing.Size(203, 36);
            this.lbl_xacNhanMK.TabIndex = 15;
            this.lbl_xacNhanMK.Text = "Xác nhận mật khẩu";
            this.lbl_xacNhanMK.Click += new System.EventHandler(this.lbl_xacNhanMK_Click);
            // 
            // txt_MK
            // 
            this.txt_MK.AutoSize = true;
            this.txt_MK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MK.DefaultText = "";
            this.txt_MK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MK.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_MK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MK.Location = new System.Drawing.Point(1087, 169);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.PlaceholderText = "";
            this.txt_MK.SelectedText = "";
            this.txt_MK.Size = new System.Drawing.Size(525, 45);
            this.txt_MK.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MK.TabIndex = 14;
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 50;
            this.guna2GradientPanel1.Controls.Add(this.btn_Refresh);
            this.guna2GradientPanel1.Controls.Add(this.cbo_VaiTro);
            this.guna2GradientPanel1.Controls.Add(this.btn_vohieuhoa);
            this.guna2GradientPanel1.Controls.Add(this.txt_search);
            this.guna2GradientPanel1.Controls.Add(this.btn_sua);
            this.guna2GradientPanel1.Controls.Add(this.txt_TinhTrang);
            this.guna2GradientPanel1.Controls.Add(this.lbl_mota);
            this.guna2GradientPanel1.Controls.Add(this.txt_maNV);
            this.guna2GradientPanel1.Controls.Add(this.txt_DiaChi);
            this.guna2GradientPanel1.Controls.Add(this.lbl_TinhTrang);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.lbl_maNV);
            this.guna2GradientPanel1.Controls.Add(this.txt_XacNhanMK);
            this.guna2GradientPanel1.Controls.Add(this.lbl_tenNV);
            this.guna2GradientPanel1.Controls.Add(this.lbl_xacNhanMK);
            this.guna2GradientPanel1.Controls.Add(this.txt_tenNV);
            this.guna2GradientPanel1.Controls.Add(this.lbl_VaiTro);
            this.guna2GradientPanel1.Controls.Add(this.txt_MK);
            this.guna2GradientPanel1.Controls.Add(this.dgv_nhanvien);
            this.guna2GradientPanel1.Controls.Add(this.lbl_MK);
            this.guna2GradientPanel1.Controls.Add(this.lbl_GioiTinh);
            this.guna2GradientPanel1.Controls.Add(this.lbl_Email);
            this.guna2GradientPanel1.Controls.Add(this.txt_Email);
            this.guna2GradientPanel1.Controls.Add(this.rdo_Nam);
            this.guna2GradientPanel1.Controls.Add(this.rdo_Nu);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(60, 60);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1633, 876);
            this.guna2GradientPanel1.TabIndex = 25;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 434);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(220, 57);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Members";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // lbl_maNV
            // 
            this.lbl_maNV.BackColor = System.Drawing.Color.White;
            this.lbl_maNV.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maNV.Location = new System.Drawing.Point(43, 46);
            this.lbl_maNV.Name = "lbl_maNV";
            this.lbl_maNV.Size = new System.Drawing.Size(136, 36);
            this.lbl_maNV.TabIndex = 4;
            this.lbl_maNV.Text = "Mã Nhân Viên";
            this.lbl_maNV.Click += new System.EventHandler(this.lbl_maNV_Click);
            // 
            // txt_XacNhanMK
            // 
            this.txt_XacNhanMK.AutoSize = true;
            this.txt_XacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_XacNhanMK.DefaultText = "";
            this.txt_XacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_XacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_XacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_XacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_XacNhanMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_XacNhanMK.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_XacNhanMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_XacNhanMK.Location = new System.Drawing.Point(1087, 268);
            this.txt_XacNhanMK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_XacNhanMK.Name = "txt_XacNhanMK";
            this.txt_XacNhanMK.PasswordChar = '*';
            this.txt_XacNhanMK.PlaceholderText = "";
            this.txt_XacNhanMK.SelectedText = "";
            this.txt_XacNhanMK.Size = new System.Drawing.Size(525, 45);
            this.txt_XacNhanMK.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_XacNhanMK.TabIndex = 16;
            this.txt_XacNhanMK.TextChanged += new System.EventHandler(this.txt_XacNhanMK_TextChanged);
            // 
            // lbl_tenNV
            // 
            this.lbl_tenNV.BackColor = System.Drawing.Color.White;
            this.lbl_tenNV.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNV.Location = new System.Drawing.Point(34, 145);
            this.lbl_tenNV.Name = "lbl_tenNV";
            this.lbl_tenNV.Size = new System.Drawing.Size(145, 36);
            this.lbl_tenNV.TabIndex = 6;
            this.lbl_tenNV.Text = "Tên Nhân Viên";
            this.lbl_tenNV.Click += new System.EventHandler(this.lbl_tenNV_Click);
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.AutoSize = true;
            this.txt_tenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenNV.DefaultText = "";
            this.txt_tenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_tenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenNV.Location = new System.Drawing.Point(34, 190);
            this.txt_tenNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.PasswordChar = '\0';
            this.txt_tenNV.PlaceholderText = "";
            this.txt_tenNV.SelectedText = "";
            this.txt_tenNV.Size = new System.Drawing.Size(525, 45);
            this.txt_tenNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_tenNV.TabIndex = 9;
            this.txt_tenNV.TextChanged += new System.EventHandler(this.txt_tenNV_TextChanged);
            // 
            // lbl_VaiTro
            // 
            this.lbl_VaiTro.BackColor = System.Drawing.Color.White;
            this.lbl_VaiTro.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VaiTro.Location = new System.Drawing.Point(34, 244);
            this.lbl_VaiTro.Name = "lbl_VaiTro";
            this.lbl_VaiTro.Size = new System.Drawing.Size(73, 36);
            this.lbl_VaiTro.TabIndex = 20;
            this.lbl_VaiTro.Text = "Vai trò";
            this.lbl_VaiTro.Click += new System.EventHandler(this.lbl_VaiTro_Click);
            // 
            // dgv_nhanvien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nhanvien.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SVN-Prima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhanvien.ColumnHeadersHeight = 50;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calisto MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_nhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.Location = new System.Drawing.Point(25, 500);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_nhanvien.RowHeadersVisible = false;
            this.dgv_nhanvien.RowTemplate.Height = 50;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1001, 366);
            this.dgv_nhanvien.TabIndex = 1;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanvien.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_nhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nhanvien.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_nhanvien.ThemeStyle.ReadOnly = false;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nhanvien.ThemeStyle.RowsStyle.Height = 50;
            this.dgv_nhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellContentClick);
            this.dgv_nhanvien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_nhanvien_CellFormatting);
            // 
            // lbl_MK
            // 
            this.lbl_MK.BackColor = System.Drawing.Color.White;
            this.lbl_MK.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MK.Location = new System.Drawing.Point(1087, 124);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(95, 36);
            this.lbl_MK.TabIndex = 13;
            this.lbl_MK.Text = "Mật khẩu";
            this.lbl_MK.Click += new System.EventHandler(this.lbl_MK_Click);
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.BackColor = System.Drawing.Color.White;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(34, 335);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(92, 36);
            this.lbl_GioiTinh.TabIndex = 18;
            this.lbl_GioiTinh.Text = "Giới tính";
            this.lbl_GioiTinh.Click += new System.EventHandler(this.lbl_GioiTinh_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.BackColor = System.Drawing.Color.White;
            this.lbl_Email.Font = new System.Drawing.Font("SVN-Appleberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(1087, 31);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(53, 36);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.lbl_Email_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(1087, 76);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(525, 45);
            this.txt_Email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Email.TabIndex = 12;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.BackColor = System.Drawing.Color.White;
            this.rdo_Nam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Nam.CheckedState.BorderThickness = 0;
            this.rdo_Nam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Nam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Nam.CheckedState.InnerOffset = -4;
            this.rdo_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdo_Nam.Location = new System.Drawing.Point(34, 377);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(65, 26);
            this.rdo_Nam.TabIndex = 17;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Nam.UncheckedState.BorderThickness = 2;
            this.rdo_Nam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Nam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo_Nam.UseVisualStyleBackColor = false;
            this.rdo_Nam.CheckedChanged += new System.EventHandler(this.rdo_Nam_CheckedChanged);
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.BackColor = System.Drawing.Color.White;
            this.rdo_Nu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Nu.CheckedState.BorderThickness = 0;
            this.rdo_Nu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Nu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Nu.CheckedState.InnerOffset = -4;
            this.rdo_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdo_Nu.Location = new System.Drawing.Point(128, 377);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(51, 26);
            this.rdo_Nu.TabIndex = 19;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Nu.UncheckedState.BorderThickness = 2;
            this.rdo_Nu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Nu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo_Nu.UseVisualStyleBackColor = false;
            this.rdo_Nu.CheckedChanged += new System.EventHandler(this.rdo_Nu_CheckedChanged);
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 996);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhanVien";
            this.Padding = new System.Windows.Forms.Padding(60);
            this.Text = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_VaiTro;
        private Guna.UI2.WinForms.Guna2Button btn_vohieuhoa;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2TextBox txt_TinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_mota;
        private Guna.UI2.WinForms.Guna2TextBox txt_maNV;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_TinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_xacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox txt_MK;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_maNV;
        private Guna.UI2.WinForms.Guna2TextBox txt_XacNhanMK;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_tenNV;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_VaiTro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_MK;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_GioiTinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Nam;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Nu;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_nhanvien;
    }
}