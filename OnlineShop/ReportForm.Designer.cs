
namespace OnlineShop
{
    partial class ReportForm
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
            this.reportViewer_Reciept = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_Reciept
            // 
            this.reportViewer_Reciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_Reciept.LocalReport.ReportEmbeddedResource = "OnlineShop.Receipt.rdlc";
            this.reportViewer_Reciept.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_Reciept.Name = "reportViewer_Reciept";
            this.reportViewer_Reciept.ServerReport.BearerToken = null;
            this.reportViewer_Reciept.Size = new System.Drawing.Size(1178, 844);
            this.reportViewer_Reciept.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.reportViewer_Reciept);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer_Reciept;
    }
}