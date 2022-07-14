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
    public partial class FormAddOrder_AddProduct : Form
    {
        // global vars
        public static int SetValueForProductId = 0;
        public static int SetValueForQuantity = 0;
        public static double SetValueForTotalPrice = 0;

        public FormAddOrder_AddProduct()
        {
            InitializeComponent();
            LoadProductId();
        }

        private bool checkQuantity()
        {
            if (nupQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be larger than 0 !!!");
                return false;
            }
            return true;
        }

        private void LoadProductId()
        {
            ProductRepositoryEF productRepositoryEF = new ProductRepositoryEF();
            cbProductID.DisplayMember = "Name";
            cbProductID.ValueMember = "Id";
            cbProductID.DataSource = productRepositoryEF.Get();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (checkQuantity())
            {
                SetValueForProductId = (int)cbProductID.SelectedValue;
                SetValueForQuantity = (int)nupQuantity.Value;
                SetValueForTotalPrice = Convert.ToDouble(labelTotalPrice.Text);
                this.Close();
            }
        }

        private void UpdateLabelTotalPrice()
        {
            ProductRepositoryEF productRepositoryEF = new ProductRepositoryEF();
            labelTotalPrice.Text = ((double)nupQuantity.Value * productRepositoryEF.GetProductPrice((int)cbProductID.SelectedValue)).ToString();
        }

        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabelTotalPrice();
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabelTotalPrice();
        }
    }
}
