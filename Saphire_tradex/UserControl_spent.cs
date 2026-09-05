using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saphire_tradex
{
    public partial class UserControl_spent : UserControl
    {
        public UserControl_spent()
        {
            InitializeComponent();
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double wat_bill = Convert.ToDouble(guna2TextBox_wa_bill.Text);
            double ele_bill = Convert.ToDouble(guna2TextBox_ele_bill.Text);
            double other = Convert.ToDouble(guna2TextBox_other.Text);
            double rental = Convert.ToDouble(guna2TextBox_rental.Text);
            double total_sales = Convert.ToDouble(guna2TextBox_tot_sales.Text);
            double income = total_sales - (wat_bill + ele_bill + other + rental);
            label_final.Text = "LKR "+income.ToString();
            guna2TextBox_tot_income.Visible = false;
            label_final.Visible = true;


        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
