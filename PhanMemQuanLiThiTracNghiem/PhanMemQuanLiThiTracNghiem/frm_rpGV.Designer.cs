namespace PhanMemQuanLiThiTracNghiem
{
    partial class frm_rpGV
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
            this.rpGV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpGV
            // 
            this.rpGV.ActiveViewIndex = -1;
            this.rpGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpGV.Location = new System.Drawing.Point(0, 0);
            this.rpGV.Name = "rpGV";
            this.rpGV.Size = new System.Drawing.Size(984, 692);
            this.rpGV.TabIndex = 0;
            // 
            // frm_rpGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 692);
            this.Controls.Add(this.rpGV);
            this.Name = "frm_rpGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo biểu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_rpGV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpGV;
    }
}