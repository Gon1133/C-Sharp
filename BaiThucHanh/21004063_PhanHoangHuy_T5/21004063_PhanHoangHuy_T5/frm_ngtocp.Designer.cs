namespace _21004063_PhanHoangHuy_T5
{
    partial class frm_ngtocp
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
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.txt_kiemtra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số nguyên dương";
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapso.Location = new System.Drawing.Point(237, 38);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(160, 29);
            this.txt_nhapso.TabIndex = 1;
            this.txt_nhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhapso_KeyPress);
            // 
            // txt_kiemtra
            // 
            this.txt_kiemtra.AutoSize = true;
            this.txt_kiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kiemtra.Location = new System.Drawing.Point(156, 101);
            this.txt_kiemtra.Name = "txt_kiemtra";
            this.txt_kiemtra.Size = new System.Drawing.Size(88, 34);
            this.txt_kiemtra.TabIndex = 2;
            this.txt_kiemtra.Text = "Kiểm tra";
            this.txt_kiemtra.UseVisualStyleBackColor = true;
            this.txt_kiemtra.Click += new System.EventHandler(this.txt_kiemtra_Click);
            // 
            // frm_ngtocp
            // 
            this.AcceptButton = this.txt_kiemtra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 172);
            this.Controls.Add(this.txt_kiemtra);
            this.Controls.Add(this.txt_nhapso);
            this.Controls.Add(this.label1);
            this.Name = "frm_ngtocp";
            this.Text = "Số nguyên tố, số chính phương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhapso;
        private System.Windows.Forms.Button txt_kiemtra;
    }
}