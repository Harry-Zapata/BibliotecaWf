namespace biblioteca.Precentacion
{
    partial class Reporte
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
            this.CRview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRview
            // 
            this.CRview.ActiveViewIndex = -1;
            this.CRview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRview.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRview.Location = new System.Drawing.Point(0, 0);
            this.CRview.Name = "CRview";
            this.CRview.Size = new System.Drawing.Size(952, 709);
            this.CRview.TabIndex = 0;
            this.CRview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRview.Load += new System.EventHandler(this.CRview_Load);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 709);
            this.Controls.Add(this.CRview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRview;
    }
}