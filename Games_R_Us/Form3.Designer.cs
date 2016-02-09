namespace Games_R_Us
{
    partial class frmYourCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYourCart));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblShoppingCartBanner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFieldSalesTax = new System.Windows.Forms.Label();
            this.lblShipRate = new System.Windows.Forms.Label();
            this.lblFieldTotal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblFieldConsole = new System.Windows.Forms.Label();
            this.lblFieldTitle = new System.Windows.Forms.Label();
            this.lblFieldPrice = new System.Windows.Forms.Label();
            this.lblFieldSub = new System.Windows.Forms.Label();
            this.cbbShipping = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.Location = new System.Drawing.Point(682, 563);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(165, 23);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblShoppingCartBanner
            // 
            this.lblShoppingCartBanner.AutoSize = true;
            this.lblShoppingCartBanner.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCartBanner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShoppingCartBanner.Location = new System.Drawing.Point(266, 94);
            this.lblShoppingCartBanner.Name = "lblShoppingCartBanner";
            this.lblShoppingCartBanner.Size = new System.Drawing.Size(346, 32);
            this.lblShoppingCartBanner.TabIndex = 2;
            this.lblShoppingCartBanner.Text = "Please Review Your Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 67);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblFieldSalesTax
            // 
            this.lblFieldSalesTax.AutoSize = true;
            this.lblFieldSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldSalesTax.Location = new System.Drawing.Point(530, 421);
            this.lblFieldSalesTax.Name = "lblFieldSalesTax";
            this.lblFieldSalesTax.Size = new System.Drawing.Size(78, 16);
            this.lblFieldSalesTax.TabIndex = 4;
            this.lblFieldSalesTax.Text = "Sales Tax";
            // 
            // lblShipRate
            // 
            this.lblShipRate.AutoSize = true;
            this.lblShipRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipRate.Location = new System.Drawing.Point(733, 466);
            this.lblShipRate.Name = "lblShipRate";
            this.lblShipRate.Size = new System.Drawing.Size(0, 16);
            this.lblShipRate.TabIndex = 9;
            // 
            // lblFieldTotal
            // 
            this.lblFieldTotal.AutoSize = true;
            this.lblFieldTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldTotal.Location = new System.Drawing.Point(530, 524);
            this.lblFieldTotal.Name = "lblFieldTotal";
            this.lblFieldTotal.Size = new System.Drawing.Size(44, 16);
            this.lblFieldTotal.TabIndex = 10;
            this.lblFieldTotal.Text = "Total";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(87, 188);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 16);
            this.lblType.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(269, 188);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 16);
            this.lblTitle.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(530, 188);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 13;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(735, 374);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 16);
            this.lblSubTotal.TabIndex = 14;
            // 
            // lblFieldConsole
            // 
            this.lblFieldConsole.AutoSize = true;
            this.lblFieldConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldConsole.Location = new System.Drawing.Point(87, 146);
            this.lblFieldConsole.Name = "lblFieldConsole";
            this.lblFieldConsole.Size = new System.Drawing.Size(65, 16);
            this.lblFieldConsole.TabIndex = 15;
            this.lblFieldConsole.Text = "Console";
            // 
            // lblFieldTitle
            // 
            this.lblFieldTitle.AutoSize = true;
            this.lblFieldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldTitle.Location = new System.Drawing.Point(269, 146);
            this.lblFieldTitle.Name = "lblFieldTitle";
            this.lblFieldTitle.Size = new System.Drawing.Size(39, 16);
            this.lblFieldTitle.TabIndex = 16;
            this.lblFieldTitle.Text = "Title";
            // 
            // lblFieldPrice
            // 
            this.lblFieldPrice.AutoSize = true;
            this.lblFieldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldPrice.Location = new System.Drawing.Point(530, 146);
            this.lblFieldPrice.Name = "lblFieldPrice";
            this.lblFieldPrice.Size = new System.Drawing.Size(44, 16);
            this.lblFieldPrice.TabIndex = 17;
            this.lblFieldPrice.Text = "Price";
            // 
            // lblFieldSub
            // 
            this.lblFieldSub.AutoSize = true;
            this.lblFieldSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldSub.Location = new System.Drawing.Point(530, 374);
            this.lblFieldSub.Name = "lblFieldSub";
            this.lblFieldSub.Size = new System.Drawing.Size(71, 16);
            this.lblFieldSub.TabIndex = 18;
            this.lblFieldSub.Text = "SubTotal";
            // 
            // cbbShipping
            // 
            this.cbbShipping.FormattingEnabled = true;
            this.cbbShipping.Location = new System.Drawing.Point(531, 465);
            this.cbbShipping.Name = "cbbShipping";
            this.cbbShipping.Size = new System.Drawing.Size(156, 21);
            this.cbbShipping.TabIndex = 19;
            this.cbbShipping.SelectedIndexChanged += new System.EventHandler(this.cbbShipping_SelectedIndexChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(734, 417);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 16);
            this.lblTax.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(735, 527);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 21;
            // 
            // frmYourCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 623);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.cbbShipping);
            this.Controls.Add(this.lblFieldSub);
            this.Controls.Add(this.lblFieldPrice);
            this.Controls.Add(this.lblFieldTitle);
            this.Controls.Add(this.lblFieldConsole);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFieldTotal);
            this.Controls.Add(this.lblShipRate);
            this.Controls.Add(this.lblFieldSalesTax);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblShoppingCartBanner);
            this.Controls.Add(this.btnCheckout);
            this.Name = "frmYourCart";
            this.Text = "Games R Us - Review Your Shopping Cart";
            this.Load += new System.EventHandler(this.frmYourCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblShoppingCartBanner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFieldSalesTax;
        private System.Windows.Forms.Label lblShipRate;
        private System.Windows.Forms.Label lblFieldTotal;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblFieldConsole;
        private System.Windows.Forms.Label lblFieldTitle;
        private System.Windows.Forms.Label lblFieldPrice;
        private System.Windows.Forms.Label lblFieldSub;
        private System.Windows.Forms.ComboBox cbbShipping;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}