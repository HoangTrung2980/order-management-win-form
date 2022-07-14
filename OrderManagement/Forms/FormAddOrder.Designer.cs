namespace OrderManagement.Forms
{
    partial class FormAddOrder
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupOrderID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nupOrderStatus = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTotalPayAmount = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(189, 83);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(270, 27);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID";
            // 
            // nupOrderID
            // 
            this.nupOrderID.Enabled = false;
            this.nupOrderID.Location = new System.Drawing.Point(189, 34);
            this.nupOrderID.Name = "nupOrderID";
            this.nupOrderID.Size = new System.Drawing.Size(150, 27);
            this.nupOrderID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(189, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 27);
            this.txtAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // nupPrice
            // 
            this.nupPrice.Enabled = false;
            this.nupPrice.Location = new System.Drawing.Point(189, 175);
            this.nupPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(150, 27);
            this.nupPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Order Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(189, 221);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(250, 27);
            this.dtpOrderDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order Status";
            // 
            // nupOrderStatus
            // 
            this.nupOrderStatus.Location = new System.Drawing.Point(189, 271);
            this.nupOrderStatus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupOrderStatus.Name = "nupOrderStatus";
            this.nupOrderStatus.Size = new System.Drawing.Size(150, 27);
            this.nupOrderStatus.TabIndex = 5;
            this.nupOrderStatus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Order Detail";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(690, 34);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(114, 29);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvOrderDetail.Location = new System.Drawing.Point(541, 76);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(428, 222);
            this.dgvOrderDetail.TabIndex = 8;
            this.dgvOrderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellValueChanged);
            this.dgvOrderDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOrderDetail_RowsAdded);
            this.dgvOrderDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvOrderDetail_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Order Payment";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(189, 327);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(114, 29);
            this.btnAddPayment.TabIndex = 7;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPayment.Location = new System.Drawing.Point(34, 362);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 29;
            this.dgvPayment.Size = new System.Drawing.Size(431, 120);
            this.dgvPayment.TabIndex = 9;
            this.dgvPayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellValueChanged);
            this.dgvPayment.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPayment_RowsAdded);
            this.dgvPayment.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPayment_RowsRemoved);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PayTime";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PayType";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(842, 453);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 29);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Price";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(856, 331);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(80, 20);
            this.labelTotalPrice.TabIndex = 11;
            this.labelTotalPrice.Text = "Sum(Price)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total Pay Amount";
            // 
            // labelTotalPayAmount
            // 
            this.labelTotalPayAmount.AutoSize = true;
            this.labelTotalPayAmount.Location = new System.Drawing.Point(856, 362);
            this.labelTotalPayAmount.Name = "labelTotalPayAmount";
            this.labelTotalPayAmount.Size = new System.Drawing.Size(101, 20);
            this.labelTotalPayAmount.TabIndex = 11;
            this.labelTotalPayAmount.Text = "Sum(Amount)";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(822, 34);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(114, 29);
            this.btnEditProduct.TabIndex = 7;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 526);
            this.Controls.Add(this.labelTotalPayAmount);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnEditProduct);
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
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupOrderStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTotalPayAmount;
        private System.Windows.Forms.Button btnEditProduct;
    }
}