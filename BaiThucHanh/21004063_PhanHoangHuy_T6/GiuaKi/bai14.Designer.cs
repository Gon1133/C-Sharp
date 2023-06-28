namespace GiuaKi
{
    partial class bai14
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
            this.btn_phatsinh = new System.Windows.Forms.Button();
            this.txt_nhapmang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_giamdan = new System.Windows.Forms.Button();
            this.btn_tangdan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_cu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_moi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử mảng";
            // 
            // btn_phatsinh
            // 
            this.btn_phatsinh.AutoSize = true;
            this.btn_phatsinh.Enabled = false;
            this.btn_phatsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phatsinh.Location = new System.Drawing.Point(315, 4);
            this.btn_phatsinh.Name = "btn_phatsinh";
            this.btn_phatsinh.Size = new System.Drawing.Size(214, 30);
            this.btn_phatsinh.TabIndex = 1;
            this.btn_phatsinh.Text = "Phát sinh giá trị các phần tử";
            this.btn_phatsinh.UseVisualStyleBackColor = true;
            this.btn_phatsinh.Click += new System.EventHandler(this.btn_phatsinh_Click);
            // 
            // txt_nhapmang
            // 
            this.txt_nhapmang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmang.Location = new System.Drawing.Point(187, 6);
            this.txt_nhapmang.Name = "txt_nhapmang";
            this.txt_nhapmang.Size = new System.Drawing.Size(100, 26);
            this.txt_nhapmang.TabIndex = 2;
            this.txt_nhapmang.TextChanged += new System.EventHandler(this.txt_nhapmang_TextChanged);
            this.txt_nhapmang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhap_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị mảng";
            // 
            // txt_mang
            // 
            this.txt_mang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mang.Location = new System.Drawing.Point(28, 43);
            this.txt_mang.Name = "txt_mang";
            this.txt_mang.Size = new System.Drawing.Size(713, 26);
            this.txt_mang.TabIndex = 9;
            this.txt_mang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_giamdan);
            this.groupBox2.Controls.Add(this.btn_tangdan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // btn_giamdan
            // 
            this.btn_giamdan.AutoSize = true;
            this.btn_giamdan.Enabled = false;
            this.btn_giamdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giamdan.Location = new System.Drawing.Point(303, 40);
            this.btn_giamdan.Name = "btn_giamdan";
            this.btn_giamdan.Size = new System.Drawing.Size(88, 30);
            this.btn_giamdan.TabIndex = 11;
            this.btn_giamdan.Text = "Giảm dần";
            this.btn_giamdan.UseVisualStyleBackColor = true;
            this.btn_giamdan.Click += new System.EventHandler(this.btn_giamdan_Click);
            // 
            // btn_tangdan
            // 
            this.btn_tangdan.AutoSize = true;
            this.btn_tangdan.Enabled = false;
            this.btn_tangdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tangdan.Location = new System.Drawing.Point(95, 40);
            this.btn_tangdan.Name = "btn_tangdan";
            this.btn_tangdan.Size = new System.Drawing.Size(86, 30);
            this.btn_tangdan.TabIndex = 12;
            this.btn_tangdan.Text = "Tăng dần";
            this.btn_tangdan.UseVisualStyleBackColor = true;
            this.btn_tangdan.Click += new System.EventHandler(this.btn_tangdan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.txt_cu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_moi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa";
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.Enabled = false;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(442, 42);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 30);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Thực hiện sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_cu
            // 
            this.txt_cu.Enabled = false;
            this.txt_cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cu.Location = new System.Drawing.Point(257, 26);
            this.txt_cu.Name = "txt_cu";
            this.txt_cu.Size = new System.Drawing.Size(100, 26);
            this.txt_cu.TabIndex = 8;
            this.txt_cu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sửa đổi các phần tử có giá trị";
            // 
            // txt_moi
            // 
            this.txt_moi.Enabled = false;
            this.txt_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moi.Location = new System.Drawing.Point(257, 62);
            this.txt_moi.Name = "txt_moi";
            this.txt_moi.Size = new System.Drawing.Size(100, 26);
            this.txt_moi.TabIndex = 7;
            this.txt_moi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_moi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thành giá trị mới";
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.AutoSize = true;
            this.btn_lamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamlai.Location = new System.Drawing.Point(535, 4);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(75, 30);
            this.btn_lamlai.TabIndex = 10;
            this.btn_lamlai.Text = "Làm lại";
            this.btn_lamlai.UseVisualStyleBackColor = true;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btn_lamlai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nhapmang);
            this.Controls.Add(this.btn_phatsinh);
            this.Controls.Add(this.label1);
            this.Name = "bai14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sắp xếp và cập nhật mảng";
            this.Load += new System.EventHandler(this.bai14_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_phatsinh;
        private System.Windows.Forms.TextBox txt_nhapmang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_giamdan;
        private System.Windows.Forms.Button btn_tangdan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_cu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_moi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lamlai;
    }
}