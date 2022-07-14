using OrderManagement.Forms;
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

namespace OrderManagement
{
    public partial class ucProduct : UserControl
    {
        private void LoadData()
        {
            ProductRepositoryEF repository = new ProductRepositoryEF();
            var products = repository.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = products;
        }
        public ucProduct()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;// can't find with Cells["Id"] khanh's change it to Cells[0]
                    ProductRepositoryEF repository = new ProductRepositoryEF();
                    repository.Delete(id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete!");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.ShowDialog();
            LoadData();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            FormUpdateProduct formUpdateProduct = new FormUpdateProduct();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var product = new Product()
                {
                    Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                    Name = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    Price = (double?)dataGridView1.SelectedRows[0].Cells[2].Value,
                    CreatedDate = (DateTime?)dataGridView1.SelectedRows[0].Cells[3].Value,
                    Status = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    CategoryId = (int)dataGridView1.SelectedRows[0].Cells[5].Value
                };
                formUpdateProduct.LoadProduct(product);
            }
            formUpdateProduct.ShowDialog();
            LoadData();
        }
    }
}
