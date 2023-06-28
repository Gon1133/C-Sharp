namespace _21004063_PhanHoangHuy_T5
{
    partial class bai10
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
            this.grp_nhapso = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.lbx_nhapso = new System.Windows.Forms.ListBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_demso = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_demNT = new System.Windows.Forms.Button();
            this.cbb_nhapso = new System.Windows.Forms.ComboBox();
            this.grp_nhapso.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_nhapso
            // 
            this.grp_nhapso.Controls.Add(this.cbb_nhapso);
            this.grp_nhapso.Controls.Add(this.btn_capnhat);
            this.grp_nhapso.Controls.Add(this.txt_nhapso);
            this.grp_nhapso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_nhapso.Location = new System.Drawing.Point(27, 12);
            this.grp_nhapso.Name = "grp_nhapso";
            this.grp_nhapso.Size = new System.Drawing.Size(277, 132);
            this.grp_nhapso.TabIndex = 0;
            this.grp_nhapso.TabStop = false;
            this.grp_nhapso.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_nhapso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Location = new System.Drawing.Point(6, 28);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(145, 29);
            this.txt_nhapso.TabIndex = 0;
            this.txt_nhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhapso_KeyPress);
            // 
            // lbx_nhapso
            // 
            this.lbx_nhapso.FormattingEnabled = true;
            this.lbx_nhapso.ItemHeight = 24;
            this.lbx_nhapso.Location = new System.Drawing.Point(6, 30);
            this.lbx_nhapso.Name = "lbx_nhapso";
            this.lbx_nhapso.Size = new System.Drawing.Size(222, 172);
            this.lbx_nhapso.TabIndex = 0;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.AutoSize = true;
            this.btn_capnhat.Location = new System.Drawing.Point(167, 26);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(95, 34);
            this.btn_capnhat.TabIndex = 1;
            this.btn_capnhat.Text = "&Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_tong
            // 
            this.btn_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tong.Location = new System.Drawing.Point(308, 273);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(282, 34);
            this.btn_tong.TabIndex = 2;
            this.btn_tong.Text = "&Tổng các ước số";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // btn_demso
            // 
            this.btn_demso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demso.Location = new System.Drawing.Point(308, 320);
            this.btn_demso.Name = "btn_demso";
            this.btn_demso.Size = new System.Drawing.Size(282, 34);
            this.btn_demso.TabIndex = 3;
            this.btn_demso.Text = "&Số lượng các ước số chẵn";
            this.btn_demso.UseVisualStyleBackColor = true;
            this.btn_demso.Click += new System.EventHandler(this.btn_demso_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(207, 369);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(82, 34);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Th&oát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_demNT
            // 
            this.btn_demNT.AutoSize = true;
            this.btn_demNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demNT.Location = new System.Drawing.Point(308, 369);
            this.btn_demNT.Name = "btn_demNT";
            this.btn_demNT.Size = new System.Drawing.Size(282, 34);
            this.btn_demNT.TabIndex = 5;
            this.btn_demNT.Text = "Số lượng các ước số &nguyên tố";
            this.btn_demNT.UseVisualStyleBackColor = true;
            this.btn_demNT.Click += new System.EventHandler(this.btn_demNT_Click);
            // 
            // cbb_nhapso
            // 
            this.cbb_nhapso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhapso.FormattingEnabled = true;
            this.cbb_nhapso.Location = new System.Drawing.Point(6, 75);
            this.cbb_nhapso.Name = "cbb_nhapso";
            this.cbb_nhapso.Size = new System.Drawing.Size(256, 32);
            this.cbb_nhapso.TabIndex = 2;
            this.cbb_nhapso.SelectedIndexChanged += new System.EventHandler(this.cbb_nhapso_SelectedIndexChanged);
            // 
            // bai10
            // 
            this.AcceptButton = this.btn_capnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.btn_demNT);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_demso);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_nhapso);
            this.Name = "bai10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.grp_nhapso.ResumeLayout(false);
            this.grp_nhapso.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_nhapso;
        private System.Windows.Forms.ComboBox cbb_nhapso;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.TextBox txt_nhapso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_nhapso;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_demso;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_demNT;
    }
}