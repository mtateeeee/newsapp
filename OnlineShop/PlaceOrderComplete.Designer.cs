
namespace OnlineShop
{
    partial class PlaceOrderComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderComplete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PlaceOrder = new CustomControls.RJControls.RJButton();
            this.ptr_PlaceOrder = new System.Windows.Forms.PictureBox();
            this.ptr_QR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptr_QR);
            this.panel1.Controls.Add(this.ptr_PlaceOrder);
            this.panel1.Controls.Add(this.btn_PlaceOrder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 844);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "FOR SHOPPING AT SAKURA AUDIO STORE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(443, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "THANK YOU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.BackColor = System.Drawing.Color.HotPink;
            this.btn_PlaceOrder.BackgroundColor = System.Drawing.Color.HotPink;
            this.btn_PlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.btn_PlaceOrder.BorderRadius = 0;
            this.btn_PlaceOrder.BorderSize = 1;
            this.btn_PlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlaceOrder.FlatAppearance.BorderSize = 0;
            this.btn_PlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlaceOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_PlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PlaceOrder.Location = new System.Drawing.Point(358, 157);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Size = new System.Drawing.Size(436, 63);
            this.btn_PlaceOrder.TabIndex = 10;
            this.btn_PlaceOrder.Text = "CONTINUE SHOPPING";
            this.btn_PlaceOrder.TextColor = System.Drawing.Color.White;
            this.btn_PlaceOrder.UseVisualStyleBackColor = false;
            // 
            // ptr_PlaceOrder
            // 
            this.ptr_PlaceOrder.BackColor = System.Drawing.Color.HotPink;
            this.ptr_PlaceOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_PlaceOrder.BackgroundImage")));
            this.ptr_PlaceOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_PlaceOrder.Location = new System.Drawing.Point(362, 161);
            this.ptr_PlaceOrder.Name = "ptr_PlaceOrder";
            this.ptr_PlaceOrder.Size = new System.Drawing.Size(55, 55);
            this.ptr_PlaceOrder.TabIndex = 11;
            this.ptr_PlaceOrder.TabStop = false;
            // 
            // ptr_QR
            // 
            this.ptr_QR.Location = new System.Drawing.Point(375, 226);
            this.ptr_QR.Name = "ptr_QR";
            this.ptr_QR.Size = new System.Drawing.Size(400, 400);
            this.ptr_QR.TabIndex = 12;
            this.ptr_QR.TabStop = false;
            // 
            // PlaceOrderComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrderComplete";
            this.Text = "PlaceOrderComplete";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_QR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton btn_PlaceOrder;
        private System.Windows.Forms.PictureBox ptr_PlaceOrder;
        private System.Windows.Forms.PictureBox ptr_QR;
    }
}