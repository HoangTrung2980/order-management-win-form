namespace OrderManagement.Forms
{
    partial class FormUpdateOrder
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
            this.labelTotalPayAmount = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.nupOrderStatus = new System.Windows.Forms.NumericUpDown();
            this.nupOrderID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderID)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPayAmount
            // 
            this.labelTotalPayAmount.AutoSize = true;
            this.labelTotalPayAmount.Location = new System.Drawing.Point(839, 340);
            this.labelTotalPayAmount.Name = "labelTotalPayAmount";
            this.labelTotalPayAmount.Size = new System.Drawing.Size(101, 20);
            this.labelTotalPayAmount.TabIndex = 34;
            this.labelTotalPayAmount.Text = "Sum(Amount)";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(839, 309);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(80, 20);
            this.labelTotalPrice.TabIndex = 33;
            this.labelTotalPrice.Text = "Sum(Price)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(706, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total Price";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(825, 431);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(115, 29);
            this.btnUpdateOrder.TabIndex = 30;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPayment.Location = new System.Drawing.Point(17, 340);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 29;
            this.dgvPayment.Size = new System.Drawing.Size(431, 120);
            this.dgvPayment.TabIndex = 29;
            this.dgvPayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellValueChanged);
            this.dgvPayment.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPayment_RowsAdded);
            this.dgvPayment.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPayment_RowsRemoved);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PayTime";
            this.Column4.HeaderText = "PayTime";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Amount";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PayType";
            this.Column6.HeaderText = "PayType";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "PaymentID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(706, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total Pay Amount";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8});
            this.dgvOrderDetail.Location = new System.Drawing.Point(524, 54);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(428, 222);
            this.dgvOrderDetail.TabIndex = 28;
            this.dgvOrderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellValueChanged);
            this.dgvOrderDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOrderDetail_RowsAdded);
            this.dgvOrderDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvOrderDetail_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductID";
            this.Column1.HeaderText = "ProductID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Id";
            this.Column8.HeaderText = "OrderDetailID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 125;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(172, 305);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(114, 29);
            this.btnAddPayment.TabIndex = 27;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(592, 15);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(114, 29);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(172, 199);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(250, 27);
            this.dtpOrderDate.TabIndex = 25;
            // 
            // nupPrice
            // 
            this.nupPrice.Enabled = false;
            this.nupPrice.Location = new System.Drawing.Point(172, 153);
            this.nupPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(150, 27);
            this.nupPrice.TabIndex = 24;
            // 
            // nupOrderStatus
            // 
            this.nupOrderStatus.Location = new System.Drawing.Point(172, 249);
            this.nupOrderStatus.Name = "nupOrderStatus";
            this.nupOrderStatus.Size = new System.Drawing.Size(150, 27);
            this.nupOrderStatus.TabIndex = 23;
            this.nupOrderStatus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupOrderID
            // 
            this.nupOrderID.Enabled = false;
            this.nupOrderID.Location = new System.Drawing.Point(172, 12);
            this.nupOrderID.Name = "nupOrderID";
            this.nupOrderID.Size = new System.Drawing.Size(150, 27);
            this.nupOrderID.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Order Date";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 104);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 27);
            this.txtAddress.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(172, 61);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(270, 27);
            this.txtCustomerName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Order Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Order Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Order Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order ID";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(717, 15);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(114, 29);
            this.btnEditProduct.TabIndex = 35;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(844, 15);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(127, 29);
            this.btnDeleteProduct.TabIndex = 35;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(295, 305);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(127, 29);
            this.btnDeletePayment.TabIndex = 36;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // FormUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 497);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.labelTotalPayAmount);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.nupOrderStatus);
            this.Controls.Add(this.nupOrderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateOrder";
            this.Text = "FormUpdateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPayAmount;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.NumericUpDown nupOrderStatus;
        private System.Windows.Forms.NumericUpDown nupOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnDeletePayment;
    }
}