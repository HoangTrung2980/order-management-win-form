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
    public partial class ucCategory : UserControl
    {
        private void LoadData()
        {
            CategoryRepositoryEF repository = new CategoryRepositoryEF();
            var categories = repository.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = categories;
        }
        public ucCategory()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;// can't find with Cells["Id"] khanh's change it to Cells[0]
                    CategoryRepositoryEF repository = new CategoryRepositoryEF();
                    repository.Delete(id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete!");
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.ShowDialog();
            LoadData();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            FormUpdateCategory formUpdateCategory = new FormUpdateCategory();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //neu lay full data thi lay bang cach nay
                //nguoc lai, lay theo Id -> GetTById trong DB
                var category = new Category()
                {
                    Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                    Name = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    Status = (int)dataGridView1.SelectedRows[0].Cells[2].Value
                };
                formUpdateCategory.LoadCategory(category);
            }
            formUpdateCategory.ShowDialog();
            LoadData();
        }
    }
}
