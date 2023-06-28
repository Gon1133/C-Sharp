namespace GiuaKi
{
    partial class nhapmang
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
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_i = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập phần tử thứ";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhap.Location = new System.Drawing.Point(187, 40);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(100, 26);
            this.txt_nhap.TabIndex = 1;
            this.txt_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhap_KeyPress);
            // 
            // btn_nhap
            // 
            this.btn_nhap.AutoSize = true;
            this.btn_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap.Location = new System.Drawing.Point(52, 95);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(75, 30);
            this.btn_nhap.TabIndex = 2;
            this.btn_nhap.Text = "Nhập";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(212, 95);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 30);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_i
            // 
            this.lbl_i.AutoSize = true;
            this.lbl_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_i.Location = new System.Drawing.Point(160, 43);
            this.lbl_i.Name = "lbl_i";
            this.lbl_i.Size = new System.Drawing.Size(12, 20);
            this.lbl_i.TabIndex = 4;
            this.lbl_i.Text = "i";
            // 
            // nhapmang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 163);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_i);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.label1);
            this.Name = "nhapmang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "nhapmang";
            this.Load += new System.EventHandler(this.nhapmang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_i;
    }
}