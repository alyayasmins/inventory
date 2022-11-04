namespace InventoryApp.Resources
{
    partial class DataLaporan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cachedDataLaporan1 = new InventoryApp.CachedDataLaporan();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DataLaporan1 = new InventoryApp.DataLaporan();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.DataLaporan1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(815, 459);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // DataLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "DataLaporan";
            this.Size = new System.Drawing.Size(815, 459);
            this.ResumeLayout(false);

        }

        #endregion

        private CachedDataLaporan cachedDataLaporan1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private InventoryApp.DataLaporan DataLaporan1;
    }
}
