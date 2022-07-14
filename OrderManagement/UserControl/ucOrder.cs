using OrderManagement.Forms;
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
    public partial class ucOrder : UserControl
    {
        private void LoadData()
        {
            OrderRepositoryEF repository = new OrderRepositoryEF();
            var orders = repository.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = orders;
        }
        public ucOrder()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;// can't find with Cells["Id"] khanh's change it to Cells[0]
                    OrderRepositoryEF repository = new OrderRepositoryEF();
                    repository.Delete(id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete!");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder();
            formAddOrder.ShowDialog();
            LoadData();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            FormUpdateOrder formUpdateOrder = new FormUpdateOrder();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                formUpdateOrder.LoadOrder((int)dataGridView1.SelectedRows[0].Cells[0].Value); // take id to GetTById
            }
            formUpdateOrder.ShowDialog();
            LoadData();
        }
    }
}
