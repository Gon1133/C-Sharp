namespace _21004063_PhanHoangHuy
{
    partial class Bai7
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
            this.btn_chao = new System.Windows.Forms.Button();
            this.txt_gio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập giờ";
            // 
            // btn_chao
            // 
            this.btn_chao.AutoSize = true;
            this.btn_chao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_chao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chao.Location = new System.Drawing.Point(127, 112);
            this.btn_chao.Name = "btn_chao";
            this.btn_chao.Size = new System.Drawing.Size(77, 33);
            this.btn_chao.TabIndex = 1;
            this.btn_chao.Text = "Chào";
            this.btn_chao.UseVisualStyleBackColor = true;
            this.btn_chao.Click += new System.EventHandler(this.btn_chao_Click);
            // 
            // txt_gio
            // 
            this.txt_gio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gio.Location = new System.Drawing.Point(127, 42);
            this.txt_gio.Name = "txt_gio";
            this.txt_gio.Size = new System.Drawing.Size(100, 29);
            this.txt_gio.TabIndex = 2;
            this.txt_gio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gio_KeyPress);
            // 
            // Bai7
            // 
            this.AcceptButton = this.btn_chao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 179);
            this.Controls.Add(this.txt_gio);
            this.Controls.Add(this.btn_chao);
            this.Controls.Add(this.label1);
            this.Name = "Bai7";
            this.Text = "Chào theo giờ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chao;
        private System.Windows.Forms.TextBox txt_gio;
    }
}