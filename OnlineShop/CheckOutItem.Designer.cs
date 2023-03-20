
namespace OnlineShop
{
    partial class CheckOutItem
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
            this.ptr_Item = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // ptr_Item
            // 
            this.ptr_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Item.Location = new System.Drawing.Point(3, 3);
            this.ptr_Item.Name = "ptr_Item";
            this.ptr_Item.Size = new System.Drawing.Size(124, 124);
            this.ptr_Item.TabIndex = 0;
            this.ptr_Item.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(133, 3);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(80, 32);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(255, 49);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(110, 32);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(133, 95);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(68, 32);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity:";
            // 
            // CheckOutItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.ptr_Item);
            this.Name = "CheckOutItem";
            this.Size = new System.Drawing.Size(420, 130);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_Item;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label label1;
    }
}
