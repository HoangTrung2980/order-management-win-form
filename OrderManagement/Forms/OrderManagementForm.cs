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
    public partial class OrderManagementForm : Form
    {
        public OrderManagementForm()
        {
            InitializeComponent();
        }

        private ucCategory ucCategory;
        private ucOrder ucOrder;
        private ucProduct ucProduct;    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucCategory == null)
            {
                ucCategory = new ucCategory();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(ucCategory);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucProduct == null)
            {
                ucProduct = new ucProduct();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(ucProduct);
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucOrder == null)
            {
                ucOrder = new ucOrder();
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(ucOrder);
        }
    }
}
