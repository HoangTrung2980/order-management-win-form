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
    public partial class FormAddOrder_AddPayment : Form
    {
        // global vars
        public static DateTime SetValueForPayTime = DateTime.Today;
        public static double SetValueForPayAmount = 0;
        public static string SetValueForPayType = "";

        public FormAddOrder_AddPayment()
        {
            InitializeComponent();
        }

        private bool checkAmount()
        {
            if (nupAmount.Value <= 0)
            {
                MessageBox.Show("Pay Amount must be larger than 0 !!!");
                return false;
            }
            return true;
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (checkAmount())
            {
                SetValueForPayTime = dtpPayTime.Value;
                SetValueForPayAmount = (double)nupAmount.Value;
                SetValueForPayType = txtPayType.Text;
                this.Close();
            }
        }
    }
}
