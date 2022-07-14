namespace OrderManagement.Forms
{
    partial class FormAddOrder_AddPayment
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
            this.dtpPayTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayType = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Time";
            // 
            // dtpPayTime
            // 
            this.dtpPayTime.Location = new System.Drawing.Point(182, 42);
            this.dtpPayTime.Name = "dtpPayTime";
            this.dtpPayTime.Size = new System.Drawing.Size(250, 27);
            this.dtpPayTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pay Amount";
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(182, 89);
            this.nupAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(150, 27);
            this.nupAmount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay Type";
            // 
            // txtPayType
            // 
            this.txtPayType.Location = new System.Drawing.Point(182, 141);
            this.txtPayType.Name = "txtPayType";
            this.txtPayType.Size = new System.Drawing.Size(250, 27);
            this.txtPayType.TabIndex = 3;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(144, 216);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(114, 29);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // FormAddOrder_AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.txtPayType);
            this.Controls.Add(this.nupAmount);
            this.Controls.Add(this.dtpPayTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOrder_AddPayment";
            this.Text = "FormAddOrder_AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayType;
        private System.Windows.Forms.Button btnAddPayment;
    }
}