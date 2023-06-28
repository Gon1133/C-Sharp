namespace _21004063_PhanHoangHuy_T5
{
    partial class frm_Docso
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
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.txt_chuso = new System.Windows.Forms.TextBox();
            this.btn_doc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số (0 --> 9)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bằng chữ";
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapso.Location = new System.Drawing.Point(64, 94);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(147, 29);
            this.txt_nhapso.TabIndex = 2;
            this.txt_nhapso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhapso_KeyPress);
            // 
            // txt_chuso
            // 
            this.txt_chuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuso.Location = new System.Drawing.Point(364, 94);
            this.txt_chuso.Name = "txt_chuso";
            this.txt_chuso.ReadOnly = true;
            this.txt_chuso.Size = new System.Drawing.Size(147, 29);
            this.txt_chuso.TabIndex = 3;
            this.txt_chuso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_doc
            // 
            this.btn_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc.Location = new System.Drawing.Point(238, 94);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(99, 29);
            this.btn_doc.TabIndex = 4;
            this.btn_doc.Text = "=>";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // frm_Docso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 193);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.txt_chuso);
            this.Controls.Add(this.txt_nhapso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Docso";
            this.Text = "Đọc số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhapso;
        private System.Windows.Forms.TextBox txt_chuso;
        private System.Windows.Forms.Button btn_doc;
    }
}