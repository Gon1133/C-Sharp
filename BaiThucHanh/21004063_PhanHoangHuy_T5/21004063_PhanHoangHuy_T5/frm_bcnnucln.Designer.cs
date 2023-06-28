namespace _21004063_PhanHoangHuy_T5
{
    partial class frm_bcnnucln
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
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ucln = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bcnn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số m";
            // 
            // btn_tim
            // 
            this.btn_tim.AutoSize = true;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(84, 201);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(122, 34);
            this.btn_tim.TabIndex = 1;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_m
            // 
            this.txt_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_m.Location = new System.Drawing.Point(84, 24);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(166, 29);
            this.txt_m.TabIndex = 2;
            this.txt_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_m_KeyPress);
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(84, 64);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(166, 29);
            this.txt_n.TabIndex = 4;
            this.txt_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số n";
            // 
            // txt_ucln
            // 
            this.txt_ucln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ucln.Location = new System.Drawing.Point(84, 144);
            this.txt_ucln.Name = "txt_ucln";
            this.txt_ucln.ReadOnly = true;
            this.txt_ucln.Size = new System.Drawing.Size(166, 29);
            this.txt_ucln.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "BCNN";
            // 
            // txt_bcnn
            // 
            this.txt_bcnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bcnn.Location = new System.Drawing.Point(84, 104);
            this.txt_bcnn.Name = "txt_bcnn";
            this.txt_bcnn.ReadOnly = true;
            this.txt_bcnn.Size = new System.Drawing.Size(166, 29);
            this.txt_bcnn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "UCLN";
            // 
            // frm_bcnnucln
            // 
            this.AcceptButton = this.btn_tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 269);
            this.Controls.Add(this.txt_bcnn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ucln);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label1);
            this.Name = "frm_bcnnucln";
            this.Text = "Tính BCNN và UCLN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ucln;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bcnn;
        private System.Windows.Forms.Label label4;
    }
}