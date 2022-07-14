namespace OrderManagement.Forms
{
    partial class FormUpdateOrder_EditProduct
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
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(205, 159);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(169, 20);
            this.labelTotalPrice.TabIndex = 11;
            this.labelTotalPrice.Text = "{Quantity*Product price}";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(143, 216);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(109, 29);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(205, 100);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(150, 27);
            this.nupQuantity.TabIndex = 9;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(204, 48);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(151, 28);
            this.cbProductID.TabIndex = 8;
            this.cbProductID.SelectedIndexChanged += new System.EventHandler(this.cbProductID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Name";
            // 
            // FormUpdateOrder_EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.cbProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateOrder_EditProduct";
            this.Text = "FormUpdateOrder_EditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}