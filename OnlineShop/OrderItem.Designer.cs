
namespace OnlineShop
{
    partial class OrderItem
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
            this.adaw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // ptr_Item
            // 
            this.ptr_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptr_Item.Location = new System.Drawing.Point(3, 3);
            this.ptr_Item.Name = "ptr_Item";
            this.ptr_Item.Size = new System.Drawing.Size(144, 144);
            this.ptr_Item.TabIndex = 0;
            this.ptr_Item.TabStop = false;
            // 
            // adaw
            // 
            this.adaw.AutoSize = true;
            this.adaw.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaw.Location = new System.Drawing.Point(153, 3);
            this.adaw.Name = "adaw";
            this.adaw.Size = new System.Drawing.Size(100, 38);
            this.adaw.TabIndex = 3;
            this.adaw.Text = "Name:";
            this.adaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(292, 3);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(90, 38);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(292, 56);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(128, 38);
            this.lbl_Quantity.TabIndex = 5;
            this.lbl_Quantity.Text = "quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(292, 109);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(81, 38);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adaw);
            this.Controls.Add(this.ptr_Item);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(698, 148);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_Item;
        private System.Windows.Forms.Label adaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
    }
}
