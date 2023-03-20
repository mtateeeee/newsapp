
namespace OnlineShop
{
    partial class CartItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new CustomControls.RJControls.RJButton();
            this.ptr_Item = new System.Windows.Forms.PictureBox();
            this.btn_Minus = new CustomControls.RJControls.RJButton();
            this.btn_Add = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(243, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(78, 32);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(46, -3);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(64, 46);
            this.lbl_Quantity.TabIndex = 2;
            this.lbl_Quantity.Text = "1";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Price.Location = new System.Drawing.Point(243, 51);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(72, 32);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Minus);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.lbl_Quantity);
            this.panel1.Location = new System.Drawing.Point(248, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 44);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Clear.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Clear.BorderRadius = 5;
            this.btn_Clear.BorderSize = 1;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(249, 162);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 44);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ptr_Item
            // 
            this.ptr_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Item.Location = new System.Drawing.Point(3, 2);
            this.ptr_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_Item.Name = "ptr_Item";
            this.ptr_Item.Size = new System.Drawing.Size(226, 228);
            this.ptr_Item.TabIndex = 0;
            this.ptr_Item.TabStop = false;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Minus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_Minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minus.BackgroundImage")));
            this.btn_Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Minus.BorderRadius = 0;
            this.btn_Minus.BorderSize = 1;
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.ForeColor = System.Drawing.Color.White;
            this.btn_Minus.Location = new System.Drawing.Point(-1, -1);
            this.btn_Minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(53, 43);
            this.btn_Minus.TabIndex = 3;
            this.btn_Minus.TextColor = System.Drawing.Color.White;
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.BorderSize = 1;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(101, -1);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(53, 43);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.ptr_Item);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(1108, 232);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CartItem_MouseClick);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_Item;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private CustomControls.RJControls.RJButton btn_Add;
        private CustomControls.RJControls.RJButton btn_Minus;
        private CustomControls.RJControls.RJButton btn_Clear;
        private System.Windows.Forms.Panel panel1;
    }
}
