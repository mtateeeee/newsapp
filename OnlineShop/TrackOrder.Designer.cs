
namespace OnlineShop
{
    partial class TrackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackOrder));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_History = new System.Windows.Forms.PictureBox();
            this.btn_Cart = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.btn_History);
            this.panel3.Controls.Add(this.btn_Cart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 111);
            this.panel3.TabIndex = 4;
            // 
            // btn_History
            // 
            this.btn_History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_History.BackgroundImage")));
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.InitialImage = null;
            this.btn_History.Location = new System.Drawing.Point(694, 58);
            this.btn_History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(53, 48);
            this.btn_History.TabIndex = 2;
            this.btn_History.TabStop = false;
            // 
            // btn_Cart
            // 
            this.btn_Cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cart.BackgroundImage")));
            this.btn_Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cart.InitialImage = null;
            this.btn_Cart.Location = new System.Drawing.Point(784, 58);
            this.btn_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cart.Name = "btn_Cart";
            this.btn_Cart.Size = new System.Drawing.Size(53, 48);
            this.btn_Cart.TabIndex = 2;
            this.btn_Cart.TabStop = false;
            // 
            // TrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 675);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrackOrder";
            this.Text = "TrackOrder";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_History;
        private System.Windows.Forms.PictureBox btn_Cart;
    }
}