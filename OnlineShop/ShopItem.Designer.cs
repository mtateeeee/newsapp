
namespace OnlineShop
{
    partial class ShopItem
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.ptr_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(229, 11);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(80, 32);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(229, 49);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(68, 32);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackgroundImage = global::OnlineShop.Properties.Resources.star_vector_png_transparent_image_pngpix_21;
            this.btn_Buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buy.Image = global::OnlineShop.Properties.Resources.star_vector_png_transparent_image_pngpix_21;
            this.btn_Buy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Buy.Location = new System.Drawing.Point(8, 11);
            this.btn_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(49, 44);
            this.btn_Buy.TabIndex = 2;
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // ptr_Item
            // 
            this.ptr_Item.BackColor = System.Drawing.Color.Transparent;
            this.ptr_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Item.Location = new System.Drawing.Point(63, 2);
            this.ptr_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_Item.Name = "ptr_Item";
            this.ptr_Item.Size = new System.Drawing.Size(160, 144);
            this.ptr_Item.TabIndex = 0;
            this.ptr_Item.TabStop = false;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.ptr_Item);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(1029, 274);
            this.Load += new System.EventHandler(this.ShopItem_Load);
            this.Click += new System.EventHandler(this.ShopItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_Item;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Buy;
    }
}
