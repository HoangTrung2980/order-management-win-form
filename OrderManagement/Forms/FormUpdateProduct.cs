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
    public partial class FormUpdateProduct : Form
    {
        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        public void LoadProduct(Product product)
        {
            txtProductId.Text = product.Id.ToString();
            txtProductName.Text = product.Name;
            txtProductPrice.Text = product.Price.ToString();
            dtpProductCreatedDate.Value = product.CreatedDate.Value;
            nupProductStatus.Value = product.Status.Value;
            nupProductCategoryId.Value = product.CategoryId.Value;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProductRepositoryEF productRepositoryEF = new ProductRepositoryEF();
            var product = new Product()
            {
                Id = Convert.ToInt32(txtProductId.Text),
                Name = txtProductName.Text,
                Price = Convert.ToDouble(txtProductPrice.Text),
                CreatedDate = dtpProductCreatedDate.Value,
                Status = (int?)nupProductStatus.Value,
                CategoryId = Convert.ToInt32(nupProductCategoryId.Value)
            };
            productRepositoryEF.Update(product);
            this.Close();
        }
    }
}
