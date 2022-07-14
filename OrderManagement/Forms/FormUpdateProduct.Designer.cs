namespace OrderManagement.Forms
{
    partial class FormUpdateProduct
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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpProductCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.nupProductStatus = new System.Windows.Forms.NumericUpDown();
            this.nupProductCategoryId = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductCategoryId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(182, 26);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(208, 27);
            this.txtProductId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(182, 68);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(208, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(182, 114);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(208, 27);
            this.txtProductPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Created Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category ID";
            // 
            // dtpProductCreatedDate
            // 
            this.dtpProductCreatedDate.Location = new System.Drawing.Point(182, 158);
            this.dtpProductCreatedDate.Name = "dtpProductCreatedDate";
            this.dtpProductCreatedDate.Size = new System.Drawing.Size(250, 27);
            this.dtpProductCreatedDate.TabIndex = 2;
            // 
            // nupProductStatus
            // 
            this.nupProductStatus.Location = new System.Drawing.Point(182, 206);
            this.nupProductStatus.Name = "nupProductStatus";
            this.nupProductStatus.Size = new System.Drawing.Size(150, 27);
            this.nupProductStatus.TabIndex = 3;
            // 
            // nupProductCategoryId
            // 
            this.nupProductCategoryId.Location = new System.Drawing.Point(182, 243);
            this.nupProductCategoryId.Name = "nupProductCategoryId";
            this.nupProductCategoryId.Size = new System.Drawing.Size(150, 27);
            this.nupProductCategoryId.TabIndex = 3;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(215, 307);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.nupProductCategoryId);
            this.Controls.Add(this.nupProductStatus);
            this.Controls.Add(this.dtpProductCreatedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateProduct";
            this.Text = "Update Product";
            ((System.ComponentModel.ISupportInitialize)(this.nupProductStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductCategoryId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpProductCreatedDate;
        private System.Windows.Forms.NumericUpDown nupProductStatus;
        private System.Windows.Forms.NumericUpDown nupProductCategoryId;
        private System.Windows.Forms.Button btnUpdateProduct;
    }
}