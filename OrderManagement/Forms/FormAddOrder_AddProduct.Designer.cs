namespace OrderManagement.Forms
{
    partial class FormAddOrder_AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(201, 37);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(151, 28);
            this.cbProductID.TabIndex = 1;
            this.cbProductID.SelectedIndexChanged += new System.EventHandler(this.cbProductID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(202, 89);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(150, 27);
            this.nupQuantity.TabIndex = 2;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(140, 205);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 29);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Price";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(202, 148);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(169, 20);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "{Quantity*Product price}";
            // 
            // FormAddOrder_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.cbProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOrder_AddProduct";
            this.Text = "FormAddOrder_AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}