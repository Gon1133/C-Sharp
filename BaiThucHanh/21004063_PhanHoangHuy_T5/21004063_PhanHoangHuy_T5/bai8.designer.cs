﻿namespace _21004063_PhanHoangHuy_T5
{
    partial class bai8
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
            this.grp_nhapdate = new System.Windows.Forms.GroupBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.btn_timthu = new System.Windows.Forms.Button();
            this.lbl_ketqua = new System.Windows.Forms.Label();
            this.grp_nhapdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_nhapdate
            // 
            this.grp_nhapdate.Controls.Add(this.txt_nam);
            this.grp_nhapdate.Controls.Add(this.label2);
            this.grp_nhapdate.Controls.Add(this.txt_thang);
            this.grp_nhapdate.Controls.Add(this.label1);
            this.grp_nhapdate.Controls.Add(this.txt_ngay);
            this.grp_nhapdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_nhapdate.Location = new System.Drawing.Point(82, 44);
            this.grp_nhapdate.Name = "grp_nhapdate";
            this.grp_nhapdate.Size = new System.Drawing.Size(223, 108);
            this.grp_nhapdate.TabIndex = 9;
            this.grp_nhapdate.TabStop = false;
            this.grp_nhapdate.Text = "Nhập Ngày/tháng/năm (theo format của máy)";
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(133, 53);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(83, 29);
            this.txt_nam.TabIndex = 13;
            this.txt_nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nam_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(71, 53);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(35, 29);
            this.txt_thang.TabIndex = 12;
            this.txt_thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thang_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "/";
            // 
            // txt_ngay
            // 
            this.txt_ngay.Location = new System.Drawing.Point(11, 53);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(35, 29);
            this.txt_ngay.TabIndex = 11;
            this.txt_ngay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ngay_KeyPress);
            // 
            // btn_timthu
            // 
            this.btn_timthu.AutoSize = true;
            this.btn_timthu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_timthu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timthu.Location = new System.Drawing.Point(334, 93);
            this.btn_timthu.Name = "btn_timthu";
            this.btn_timthu.Size = new System.Drawing.Size(188, 33);
            this.btn_timthu.TabIndex = 8;
            this.btn_timthu.Text = "Tìm thứ trong tuần";
            this.btn_timthu.UseVisualStyleBackColor = true;
            this.btn_timthu.Click += new System.EventHandler(this.btn_timthu_Click);
            // 
            // lbl_ketqua
            // 
            this.lbl_ketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_ketqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ketqua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ketqua.Location = new System.Drawing.Point(94, 175);
            this.lbl_ketqua.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ketqua.Name = "lbl_ketqua";
            this.lbl_ketqua.Size = new System.Drawing.Size(428, 23);
            this.lbl_ketqua.TabIndex = 10;
            this.lbl_ketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 305);
            this.Controls.Add(this.grp_nhapdate);
            this.Controls.Add(this.btn_timthu);
            this.Controls.Add(this.lbl_ketqua);
            this.Name = "bai8";
            this.Text = "Tìm thứ trong tuần";
            this.grp_nhapdate.ResumeLayout(false);
            this.grp_nhapdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_nhapdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_timthu;
        private System.Windows.Forms.Label lbl_ketqua;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_ngay;
    }
}

