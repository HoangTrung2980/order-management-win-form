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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductRepositoryEF productRepositoryEF = new ProductRepositoryEF();
            var product = new Product()
            {
                Name = txtProductName.Text,
                Price = Convert.ToInt32(txtProductPrice.Text),
                CreatedDate = dtpProductCreatedDate.Value,
                Status = (int?)nupProductStatus.Value,
                CategoryId = (int?)nupProductCategoryID.Value
            };
            productRepositoryEF.Create(product);
            this.Close();
        }
    }
}
