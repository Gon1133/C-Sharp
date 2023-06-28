namespace _21004063_PhanHoangHuy_T5
{
    partial class bai11
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
            this.lbx_nhapso = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nhapso = new System.Windows.Forms.TextBox();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_ketthuc = new System.Windows.Forms.Button();
            this.btn_xoaDC = new System.Windows.Forms.Button();
            this.btn_chonL = new System.Windows.Forms.Button();
            this.btn_xoadangchon = new System.Windows.Forms.Button();
            this.btn_tang2 = new System.Windows.Forms.Button();
            this.btn_thayBP = new System.Windows.Forms.Button();
            this.btn_chonC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 127);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbx_nhapso
            // 
            this.lbx_nhapso.FormattingEnabled = true;
            this.lbx_nhapso.ItemHeight = 24;
            this.lbx_nhapso.Location = new System.Drawing.Point(12, 133);
            this.lbx_nhapso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbx_nhapso.Name = "lbx_nhapso";
            this.lbx_nhapso.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx_nhapso.Size = new System.Drawing.Size(183, 244);
            this.lbx_nhapso.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nhap);
            this.groupBox1.Controls.Add(this.txt_nhapso);
            this.groupBox1.Controls.Add(this.lbx_nhapso);
            this.groupBox1.Location = new System.Drawing.Point(67, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(206, 395);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_chonC);
            this.groupBox2.Controls.Add(this.btn_thayBP);
            this.groupBox2.Controls.Add(this.btn_tang2);
            this.groupBox2.Controls.Add(this.btn_xoadangchon);
            this.groupBox2.Controls.Add(this.btn_chonL);
            this.groupBox2.Controls.Add(this.btn_xoaDC);
            this.groupBox2.Controls.Add(this.btn_tong);
            this.groupBox2.Location = new System.Drawing.Point(330, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(291, 395);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý Listbox";
            // 
            // txt_nhapso
            // 
            this.txt_nhapso.Location = new System.Drawing.Point(12, 34);
            this.txt_nhapso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_nhapso.Name = "txt_nhapso";
            this.txt_nhapso.Size = new System.Drawing.Size(180, 29);
            this.txt_nhapso.TabIndex = 1;
            this.txt_nhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhapso_KeyPress);
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(12, 79);
            this.btn_nhap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(183, 42);
            this.btn_nhap.TabIndex = 2;
            this.btn_nhap.Text = "&Nhập";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // btn_tong
            // 
            this.btn_tong.AutoSize = true;
            this.btn_tong.Location = new System.Drawing.Point(23, 34);
            this.btn_tong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(242, 42);
            this.btn_tong.TabIndex = 3;
            this.btn_tong.Text = "Tổng các phần tử trong list";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // btn_ketthuc
            // 
            this.btn_ketthuc.Location = new System.Drawing.Point(67, 557);
            this.btn_ketthuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ketthuc.Name = "btn_ketthuc";
            this.btn_ketthuc.Size = new System.Drawing.Size(554, 42);
            this.btn_ketthuc.TabIndex = 10;
            this.btn_ketthuc.Text = "&KẾT THÚC";
            this.btn_ketthuc.UseVisualStyleBackColor = true;
            this.btn_ketthuc.Click += new System.EventHandler(this.btn_ketthuc_Click);
            // 
            // btn_xoaDC
            // 
            this.btn_xoaDC.Location = new System.Drawing.Point(23, 84);
            this.btn_xoaDC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_xoaDC.Name = "btn_xoaDC";
            this.btn_xoaDC.Size = new System.Drawing.Size(242, 42);
            this.btn_xoaDC.TabIndex = 4;
            this.btn_xoaDC.Text = "Xóa phần tử đầu và cuối";
            this.btn_xoaDC.UseVisualStyleBackColor = true;
            this.btn_xoaDC.Click += new System.EventHandler(this.btn_xoaDC_Click);
            // 
            // btn_chonL
            // 
            this.btn_chonL.Location = new System.Drawing.Point(23, 334);
            this.btn_chonL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_chonL.Name = "btn_chonL";
            this.btn_chonL.Size = new System.Drawing.Size(242, 42);
            this.btn_chonL.TabIndex = 9;
            this.btn_chonL.Text = "Chọn số lẻ";
            this.btn_chonL.UseVisualStyleBackColor = true;
            this.btn_chonL.Click += new System.EventHandler(this.btn_chonL_Click);
            // 
            // btn_xoadangchon
            // 
            this.btn_xoadangchon.Location = new System.Drawing.Point(23, 134);
            this.btn_xoadangchon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_xoadangchon.Name = "btn_xoadangchon";
            this.btn_xoadangchon.Size = new System.Drawing.Size(242, 42);
            this.btn_xoadangchon.TabIndex = 5;
            this.btn_xoadangchon.Text = "Xóa phần tử đang chọn";
            this.btn_xoadangchon.UseVisualStyleBackColor = true;
            this.btn_xoadangchon.Click += new System.EventHandler(this.btn_xoadangchon_Click);
            // 
            // btn_tang2
            // 
            this.btn_tang2.Location = new System.Drawing.Point(23, 184);
            this.btn_tang2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_tang2.Name = "btn_tang2";
            this.btn_tang2.Size = new System.Drawing.Size(242, 42);
            this.btn_tang2.TabIndex = 6;
            this.btn_tang2.Text = "Tăng mỗi phần tử lên 2";
            this.btn_tang2.UseVisualStyleBackColor = true;
            this.btn_tang2.Click += new System.EventHandler(this.btn_tang2_Click);
            // 
            // btn_thayBP
            // 
            this.btn_thayBP.Location = new System.Drawing.Point(23, 234);
            this.btn_thayBP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_thayBP.Name = "btn_thayBP";
            this.btn_thayBP.Size = new System.Drawing.Size(242, 42);
            this.btn_thayBP.TabIndex = 7;
            this.btn_thayBP.Text = "Thay bằng bình phương";
            this.btn_thayBP.UseVisualStyleBackColor = true;
            this.btn_thayBP.Click += new System.EventHandler(this.btn_thayBP_Click);
            // 
            // btn_chonC
            // 
            this.btn_chonC.Location = new System.Drawing.Point(23, 284);
            this.btn_chonC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_chonC.Name = "btn_chonC";
            this.btn_chonC.Size = new System.Drawing.Size(242, 42);
            this.btn_chonC.TabIndex = 8;
            this.btn_chonC.Text = "Chọn số chẵn";
            this.btn_chonC.UseVisualStyleBackColor = true;
            this.btn_chonC.Click += new System.EventHandler(this.btn_chonC_Click);
            // 
            // bai11
            // 
            this.AcceptButton = this.btn_nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 629);
            this.Controls.Add(this.btn_ketthuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "bai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bai11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_nhapso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.TextBox txt_nhapso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_chonC;
        private System.Windows.Forms.Button btn_thayBP;
        private System.Windows.Forms.Button btn_tang2;
        private System.Windows.Forms.Button btn_xoadangchon;
        private System.Windows.Forms.Button btn_chonL;
        private System.Windows.Forms.Button btn_xoaDC;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_ketthuc;
    }
}