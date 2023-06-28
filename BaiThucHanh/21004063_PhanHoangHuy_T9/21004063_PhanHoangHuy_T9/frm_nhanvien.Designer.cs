namespace _21004063_PhanHoangHuy_T9
{
    partial class frm_nhanvien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_nhanvien = new System.Windows.Forms.RadioButton();
            this.rad_truongphong = new System.Windows.Forms.RadioButton();
            this.rad_giamdoc = new System.Windows.Forms.RadioButton();
            this.cbb_bophan = new System.Windows.Forms.ComboBox();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_bophan = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToAddRows = false;
            this.dgv_nhanvien.AllowUserToDeleteRows = false;
            this.dgv_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhanvien.Location = new System.Drawing.Point(3, 22);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.ReadOnly = true;
            this.dgv_nhanvien.RowHeadersVisible = false;
            this.dgv_nhanvien.Size = new System.Drawing.Size(636, 630);
            this.dgv_nhanvien.TabIndex = 2;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MSNhanvien";
            this.Column1.HeaderText = "MSNV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Hoten";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaysinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gioitinh";
            this.Column4.HeaderText = "Nữ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quyen";
            this.Column5.HeaderText = "Quyền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(353, 538);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 35);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(238, 538);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 35);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Chỉnh sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(137, 538);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 35);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AutoSize = true;
            this.btn_lammoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(33, 538);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(98, 35);
            this.btn_lammoi.TabIndex = 18;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(122, 149);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(196, 25);
            this.txt_hoten.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ và tên:";
            // 
            // txt_ms
            // 
            this.txt_ms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ms.Location = new System.Drawing.Point(122, 102);
            this.txt_ms.Name = "txt_ms";
            this.txt_ms.Size = new System.Drawing.Size(112, 25);
            this.txt_ms.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã số nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_nhanvien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 655);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bộ phận:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_nhanvien);
            this.groupBox2.Controls.Add(this.rad_truongphong);
            this.groupBox2.Controls.Add(this.rad_giamdoc);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 133);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền";
            // 
            // rad_nhanvien
            // 
            this.rad_nhanvien.AutoSize = true;
            this.rad_nhanvien.Location = new System.Drawing.Point(63, 86);
            this.rad_nhanvien.Name = "rad_nhanvien";
            this.rad_nhanvien.Size = new System.Drawing.Size(84, 21);
            this.rad_nhanvien.TabIndex = 34;
            this.rad_nhanvien.TabStop = true;
            this.rad_nhanvien.Text = "Nhân viên";
            this.rad_nhanvien.UseVisualStyleBackColor = true;
            // 
            // rad_truongphong
            // 
            this.rad_truongphong.AutoSize = true;
            this.rad_truongphong.Location = new System.Drawing.Point(63, 52);
            this.rad_truongphong.Name = "rad_truongphong";
            this.rad_truongphong.Size = new System.Drawing.Size(110, 21);
            this.rad_truongphong.TabIndex = 33;
            this.rad_truongphong.TabStop = true;
            this.rad_truongphong.Text = "Trường phòng";
            this.rad_truongphong.UseVisualStyleBackColor = true;
            // 
            // rad_giamdoc
            // 
            this.rad_giamdoc.AutoSize = true;
            this.rad_giamdoc.Location = new System.Drawing.Point(63, 18);
            this.rad_giamdoc.Name = "rad_giamdoc";
            this.rad_giamdoc.Size = new System.Drawing.Size(82, 21);
            this.rad_giamdoc.TabIndex = 32;
            this.rad_giamdoc.TabStop = true;
            this.rad_giamdoc.Text = "Giám đốc";
            this.rad_giamdoc.UseVisualStyleBackColor = true;
            // 
            // cbb_bophan
            // 
            this.cbb_bophan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_bophan.FormattingEnabled = true;
            this.cbb_bophan.Location = new System.Drawing.Point(122, 55);
            this.cbb_bophan.Name = "cbb_bophan";
            this.cbb_bophan.Size = new System.Drawing.Size(259, 25);
            this.cbb_bophan.TabIndex = 27;
            this.cbb_bophan.SelectedIndexChanged += new System.EventHandler(this.cbb_bophan_SelectedIndexChanged);
            // 
            // dtp_ns
            // 
            this.dtp_ns.CustomFormat = "dd/MM/yyyy";
            this.dtp_ns.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ns.Location = new System.Drawing.Point(122, 199);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(96, 25);
            this.dtp_ns.TabIndex = 28;
            // 
            // rad_nam
            // 
            this.rad_nam.AutoSize = true;
            this.rad_nam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_nam.Location = new System.Drawing.Point(123, 246);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(54, 21);
            this.rad_nam.TabIndex = 29;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_nu.Location = new System.Drawing.Point(183, 246);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(44, 21);
            this.rad_nu.TabIndex = 30;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(122, 290);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(196, 25);
            this.txt_matkhau.TabIndex = 31;
            // 
            // btn_bophan
            // 
            this.btn_bophan.AutoSize = true;
            this.btn_bophan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bophan.Location = new System.Drawing.Point(444, 22);
            this.btn_bophan.Name = "btn_bophan";
            this.btn_bophan.Size = new System.Drawing.Size(98, 35);
            this.btn_bophan.TabIndex = 32;
            this.btn_bophan.Text = "Bộ phận";
            this.btn_bophan.UseVisualStyleBackColor = true;
            this.btn_bophan.Click += new System.EventHandler(this.btn_bophan_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.AutoSize = true;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(430, 78);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(115, 35);
            this.btn_dangxuat.TabIndex = 33;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 655);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btn_bophan);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.rad_nu);
            this.Controls.Add(this.rad_nam);
            this.Controls.Add(this.dtp_ns);
            this.Controls.Add(this.cbb_bophan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nhanvien";
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_nhanvien;
        private System.Windows.Forms.RadioButton rad_truongphong;
        private System.Windows.Forms.RadioButton rad_giamdoc;
        private System.Windows.Forms.ComboBox cbb_bophan;
        private System.Windows.Forms.DateTimePicker dtp_ns;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_bophan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}