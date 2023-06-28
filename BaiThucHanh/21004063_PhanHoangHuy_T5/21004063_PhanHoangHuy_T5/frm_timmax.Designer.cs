namespace _21004063_PhanHoangHuy_T5
{
    partial class frm_timmax
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(151, 45);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(201, 29);
            this.txt_a.TabIndex = 2;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(151, 103);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(201, 29);
            this.txt_b.TabIndex = 3;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            // 
            // txt_max
            // 
            this.txt_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max.Location = new System.Drawing.Point(151, 161);
            this.txt_max.Name = "txt_max";
            this.txt_max.ReadOnly = true;
            this.txt_max.Size = new System.Drawing.Size(201, 29);
            this.txt_max.TabIndex = 4;
            // 
            // btn_tim
            // 
            this.btn_tim.AutoSize = true;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(151, 214);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(82, 34);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.AutoSize = true;
            this.btn_tieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tieptuc.Location = new System.Drawing.Point(264, 214);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(88, 34);
            this.btn_tieptuc.TabIndex = 6;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lớn nhất";
            // 
            // frm_timmax
            // 
            this.AcceptButton = this.btn_tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_timmax";
            this.Text = "Tìm số lớn nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.Label label3;
    }
}