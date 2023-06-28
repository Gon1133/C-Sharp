namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_rpSV
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
            this.rpSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpSV
            // 
            this.rpSV.ActiveViewIndex = -1;
            this.rpSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpSV.Location = new System.Drawing.Point(0, 0);
            this.rpSV.Name = "rpSV";
            this.rpSV.Size = new System.Drawing.Size(800, 450);
            this.rpSV.TabIndex = 0;
            // 
            // frm_rpSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpSV);
            this.Name = "frm_rpSV";
            this.Text = "frm_rpSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpSV;
    }
}