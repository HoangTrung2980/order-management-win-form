namespace OrderManagement.Forms
{
    partial class FormAddProduct
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpProductCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.nupProductStatus = new System.Windows.Forms.NumericUpDown();
            this.nupProductCategoryID = new System.Windows.Forms.NumericUpDown();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductCategoryID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(193, 25);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(270, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(193, 70);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(270, 27);
            this.txtProductPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Created Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category ID";
            // 
            // dtpProductCreatedDate
            // 
            this.dtpProductCreatedDate.Location = new System.Drawing.Point(193, 117);
            this.dtpProductCreatedDate.Name = "dtpProductCreatedDate";
            this.dtpProductCreatedDate.Size = new System.Drawing.Size(250, 27);
            this.dtpProductCreatedDate.TabIndex = 2;
            // 
            // nupProductStatus
            // 
            this.nupProductStatus.Location = new System.Drawing.Point(193, 169);
            this.nupProductStatus.Name = "nupProductStatus";
            this.nupProductStatus.Size = new System.Drawing.Size(150, 27);
            this.nupProductStatus.TabIndex = 3;
            // 
            // nupProductCategoryID
            // 
            this.nupProductCategoryID.Location = new System.Drawing.Point(193, 212);
            this.nupProductCategoryID.Name = "nupProductCategoryID";
            this.nupProductCategoryID.Size = new System.Drawing.Size(150, 27);
            this.nupProductCategoryID.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(227, 268);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.nupProductCategoryID);
            this.Controls.Add(this.nupProductStatus);
            this.Controls.Add(this.dtpProductCreatedDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.nupProductStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductCategoryID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProductCreatedDate;
        private System.Windows.Forms.NumericUpDown nupProductStatus;
        private System.Windows.Forms.NumericUpDown nupProductCategoryID;
        private System.Windows.Forms.Button btnAddProduct;
    }
}