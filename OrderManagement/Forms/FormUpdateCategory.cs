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
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory()
        {
            InitializeComponent();
        }
        public void LoadCategory(Category category)
        { 
            txtCategoryId.Text = category.Id.ToString();
            txtCategoryName.Text = category.Name;
            txtCategoryStatus.Text = category.Status.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CategoryRepositoryEF categoryRepositoryEF = new CategoryRepositoryEF();
            var category = new Category()
            {
                Id = Convert.ToInt32(txtCategoryId.Text),
                Name = txtCategoryName.Text,
                Status = Convert.ToInt32(txtCategoryStatus.Text)
            };
            categoryRepositoryEF.Update(category);
            this.Close();
        }
    }
}
