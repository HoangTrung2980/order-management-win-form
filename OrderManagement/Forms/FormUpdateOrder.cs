using ProductDBEntityFramework.Models;
using ProductDBEntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.Forms
{
    public partial class FormUpdateOrder : Form
    {
        // private vars
        private int _OrderId;


        public FormUpdateOrder()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            // Check CustomerName and Address must not be empty
            if (txtCustomerName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("CustomerName and Address must not be empty!!!");
                return false;
            }
            // Check OrderPrice must be larger than 0
            if (nupPrice.Value <= 0)
            {
                MessageBox.Show("OrderPrice must be larger than 0!!!");
                return false;
            }

            return true;
        }

        public void LoadOrder(int orderId)
        {   
            _OrderId = orderId;

            dgvPayment.AutoGenerateColumns = false;
            dgvOrderDetail.AutoGenerateColumns = false;

            OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
            nupOrderID.Value = orderRepositoryEF.GetTById(orderId).Id;
            txtCustomerName.Text = orderRepositoryEF.GetTById(orderId).CustomerName;
            txtAddress.Text = orderRepositoryEF.GetTById(orderId).Address;
            nupPrice.Value = (decimal)orderRepositoryEF.GetTById(orderId).Price;
            dtpOrderDate.Value = (DateTime)orderRepositoryEF.GetTById(orderId).OrderDate;
            nupOrderStatus.Value = (decimal)orderRepositoryEF.GetTById(orderId).Status;
            dgvPayment.DataSource = orderRepositoryEF.GetTById(orderId).Payments;
            dgvOrderDetail.DataSource = orderRepositoryEF.GetTById(orderId).OrderDetails;
        }

        //-------------------------------DataGridView OrderDetail------------------------------------
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddOrder_AddProduct formAddOrder_AddProduct = new FormAddOrder_AddProduct();
            formAddOrder_AddProduct.ShowDialog();
            // Get data from ^
            // DataGridView data order (ProductId, Quantity, TotalPrice)

            //dgvOrderDetail.Rows.Add(FormAddOrder_AddProduct.SetValueForProductId, FormAddOrder_AddProduct.SetValueForQuantity, FormAddOrder_AddProduct.SetValueForTotalPrice);
            // Note: Can't add to DataGridView as the Update funciton Data is DataBounded a.k.a(take data from DB != Can't add new/delete row)

            // Solution: Add/Delete directly to DB
            OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
            OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
            OrderDetail orderDetail = new OrderDetail
            {
                ProductId = FormAddOrder_AddProduct.SetValueForProductId,
                OrderId = _OrderId,
                Quantity = FormAddOrder_AddProduct.SetValueForQuantity,
                Price = FormAddOrder_AddProduct.SetValueForTotalPrice
            };
            orderDetailRepositoryEF.Create(orderDetail);
            // reload DataGridView DataSource after Add/Remove
            dgvOrderDetail.DataSource = orderRepositoryEF.GetTById(_OrderId).OrderDetails;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FormUpdateOrder_EditProduct formUpdateOrder_EditProduct = new FormUpdateOrder_EditProduct();
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                formUpdateOrder_EditProduct.LoadProduct((int)dgvOrderDetail.SelectedRows[0].Cells[0].Value, (int)dgvOrderDetail.SelectedRows[0].Cells[1].Value);
                formUpdateOrder_EditProduct.ShowDialog();
                dgvOrderDetail.SelectedRows[0].Cells[0].Value = FormUpdateOrder_EditProduct.SetValueForProductId; // Update Value for ProductID
                dgvOrderDetail.SelectedRows[0].Cells[1].Value = FormUpdateOrder_EditProduct.SetValueForQuantity; // Update Value for Quantity
                dgvOrderDetail.SelectedRows[0].Cells[2].Value = FormUpdateOrder_EditProduct.SetValueForTotalPrice; // Update Value for Price
            }
            else
            {
                MessageBox.Show("Please Select a Product to edit!");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = (int)dgvOrderDetail.SelectedRows[0].Cells[3].Value;
                    OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
                    OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
                    orderDetailRepositoryEF.Delete(id);
                    // reload DataGridView DataSource after Add/Remove
                    dgvOrderDetail.DataSource = orderRepositoryEF.GetTById(_OrderId).OrderDetails;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Product to Delete!");
            }
        }

        private void UpdateTotalPrice()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow row in dgvOrderDetail.Rows)
            {
                totalPrice += Convert.ToDouble(row.Cells[2].Value);
            }
            nupPrice.Value = (decimal)totalPrice;
            labelTotalPrice.Text = totalPrice.ToString();
        }

        private void dgvOrderDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dgvOrderDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dgvOrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalPrice();
        }

        //-------------------------------DataGridView Payment------------------------------------
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            FormAddOrder_AddPayment formAddOrder_AddPayment = new FormAddOrder_AddPayment();
            formAddOrder_AddPayment.ShowDialog();
            // Get data from ^
            // DataGridView data order (PayTime, Amount, PayType)
            dgvPayment.Columns[0].DefaultCellStyle.Format = "d";
            //dgvPayment.Rows.Add(FormAddOrder_AddPayment.SetValueForPayTime, FormAddOrder_AddPayment.SetValueForPayAmount, FormAddOrder_AddPayment.SetValueForPayType);
            // Note: Can't add to DataGridView as the Update funciton Data is DataBounded a.k.a(take data from DB != Can't add new/delete row)

            // Solution: Add/Delete directly to DB
            OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
            PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
            Payment payment = new Payment
            {
                PayTime = FormAddOrder_AddPayment.SetValueForPayTime,
                Amount = FormAddOrder_AddPayment.SetValueForPayAmount,
                PayType = FormAddOrder_AddPayment.SetValueForPayType,
                OrderId = _OrderId
            };
            paymentRepositoryEF.Create(payment);
            // reload DataGridView DataSource after Add/Remove
            dgvPayment.DataSource = orderRepositoryEF.GetTById(_OrderId).Payments;
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = (int)dgvPayment.SelectedRows[0].Cells[3].Value;
                    OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
                    PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
                    paymentRepositoryEF.Delete(id);
                    // reload DataGridView DataSource after Add/Remove
                    dgvPayment.DataSource = orderRepositoryEF.GetTById(_OrderId).Payments;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Payment to Delete!");
            }
        }

        private void UpdateTotalPayAmount()
        {
            double totalAmount = 0;
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                totalAmount += Convert.ToDouble(row.Cells[1].Value);
            }
            labelTotalPayAmount.Text = totalAmount.ToString();
        }

        private void dgvPayment_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotalPayAmount();
        }

        private void dgvPayment_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalPayAmount();
        }

        private void dgvPayment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalPayAmount();
        }

        //-------------------------------"Update" Button click------------------------------------
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {


                // Get OrderDetail
                List<OrderDetail> listOrderDetail = new List<OrderDetail>();
                foreach (DataGridViewRow row in dgvOrderDetail.Rows)
                {
                    OrderDetail detail = new OrderDetail()
                    {
                        Id = Convert.ToInt32(row.Cells[3].Value), // hidden row added in DataGridView to hold Id for Updating OrderDetail (index is in adding column order)
                        ProductId = Convert.ToInt32(row.Cells[0].Value),
                        OrderId = (int)nupOrderID.Value,
                        Quantity = Convert.ToInt32(row.Cells[1].Value),
                        Price = Convert.ToDouble(row.Cells[2].Value)
                    };
                    listOrderDetail.Add(detail);
                }

                // Get Payment
                List<Payment> listPayment = new List<Payment>();
                foreach (DataGridViewRow row in dgvPayment.Rows)
                {
                    Payment payment = new Payment()
                    {
                        Id = Convert.ToInt32(row.Cells[3].Value), // hidden row added in DataGridView to hold Id for Updating Payment (index is in adding column order)
                        PayTime = Convert.ToDateTime(row.Cells[0].Value),
                        Amount = Convert.ToDouble(row.Cells[1].Value),
                        PayType = (string)row.Cells[2].Value,
                        OrderId = (int)nupOrderID.Value
                    };
                    listPayment.Add(payment);
                }

                // Add Order
                OrderRepositoryEF orderRepositoryEF = new OrderRepositoryEF();
                Order order = new Order()
                {
                    Id = (int)nupOrderID.Value,
                    CustomerName = txtCustomerName.Text,
                    Address = txtAddress.Text,
                    Price = (double)nupPrice.Value,
                    OrderDate = dtpOrderDate.Value,
                    Status = (int)nupOrderStatus.Value,
                    OrderDetails = listOrderDetail,
                    Payments = listPayment
                };
                orderRepositoryEF.Update(order);
                this.Close();
            }
        }

        
    }
}
