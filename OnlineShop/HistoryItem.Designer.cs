
namespace OnlineShop
{
    partial class HistoryItem
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
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_TotalCharge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderID.Location = new System.Drawing.Point(3, 13);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(106, 32);
            this.lbl_OrderID.TabIndex = 3;
            this.lbl_OrderID.Text = "Order ID";
            this.lbl_OrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(300, 13);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(118, 32);
            this.lbl_CustomerName.TabIndex = 3;
            this.lbl_CustomerName.Text = "Customer";
            this.lbl_CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalCharge
            // 
            this.lbl_TotalCharge.AutoSize = true;
            this.lbl_TotalCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCharge.Location = new System.Drawing.Point(593, 13);
            this.lbl_TotalCharge.Name = "lbl_TotalCharge";
            this.lbl_TotalCharge.Size = new System.Drawing.Size(149, 32);
            this.lbl_TotalCharge.TabIndex = 3;
            this.lbl_TotalCharge.Text = "Total Charge";
            this.lbl_TotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "In Process";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(292, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 65);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(585, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 65);
            this.label2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(877, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 65);
            this.label4.TabIndex = 4;
            // 
            // HistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_TotalCharge);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_OrderID);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "HistoryItem";
            this.Size = new System.Drawing.Size(1169, 65);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HistoryItem_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OrderID;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_TotalCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
