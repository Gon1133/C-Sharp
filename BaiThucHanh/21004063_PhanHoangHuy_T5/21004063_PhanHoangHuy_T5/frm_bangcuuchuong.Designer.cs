namespace _21004063_PhanHoangHuy_T5
{
    partial class frm_bangcuuchuong
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
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.lst_cuuchuong = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửu chương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhap.Location = new System.Drawing.Point(167, 34);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(100, 29);
            this.txt_nhap.TabIndex = 2;
            this.txt_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhap_KeyPress);
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.AutoSize = true;
            this.btn_thuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thuchien.Location = new System.Drawing.Point(273, 32);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(106, 34);
            this.btn_thuchien.TabIndex = 4;
            this.btn_thuchien.Text = "Thực hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // lst_cuuchuong
            // 
            this.lst_cuuchuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cuuchuong.FormattingEnabled = true;
            this.lst_cuuchuong.ItemHeight = 18;
            this.lst_cuuchuong.Location = new System.Drawing.Point(50, 109);
            this.lst_cuuchuong.Name = "lst_cuuchuong";
            this.lst_cuuchuong.Size = new System.Drawing.Size(329, 220);
            this.lst_cuuchuong.TabIndex = 5;
            // 
            // frm_bangcuuchuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 346);
            this.Controls.Add(this.lst_cuuchuong);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_bangcuuchuong";
            this.Text = "Bảng cửu chương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Button btn_thuchien;
        private System.Windows.Forms.ListBox lst_cuuchuong;
    }
}