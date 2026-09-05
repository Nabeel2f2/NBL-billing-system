using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Saphire_tradex.Form_dashboard;

namespace Saphire_tradex
{
    public partial class Form_product_table : Form
    {
        private string viewType;
        public Form_product_table(string type)
        {
            InitializeComponent();
            viewType = type;
        }
        public void SetEmployeeCount(long count)
        {
            label_totcount.Text = count.ToString();
            

        }

        public void SetCashierCount(long count)
        {
            label_cashierCount.Text = count.ToString();
        }
        public void Setmancount(long count)
        {
            label_mancount.Text = count.ToString();
            
        }
        public void RefreshEmployeeCount()  // <-- ADD THIS METHOD — this was missing
        {
            using (SQLiteConnection con = new SQLiteConnection(Database.ConnectionString))
            {
                con.Open();
                string countQuery = "SELECT COUNT(*) FROM employee";

                using (SQLiteCommand cmd = new SQLiteCommand(countQuery, con))
                {
                    long count = (long)cmd.ExecuteScalar();
                    label_totcount.Text = count.ToString();
                }
            }
        }
        private void Form_product_table_Load(object sender, EventArgs e)
        {
            //LoadEmployeeData();
            if (viewType == "Product")
            {
                guna2Panel_view_product.Visible = true;
                guna2Panel_emp_details.Visible = false;
                LoadProducts();
            }
            else if (viewType == "details")
            {
                RefreshEmployeeCount();
                guna2Panel_view_product.Visible = false;
                guna2Panel_emp_details.Visible = true;
                Load_emp_details();

            }

        }


        // Create LoadProducts here
        public void LoadProducts()
        {
            using (SQLiteConnection con = new SQLiteConnection(Database.ConnectionString))
            {
                con.Open();

                string selectQuery = "SELECT * FROM products";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);


                guna2DataGridView_viewproduct.DataSource = dt;
            }
        }
       
        public void Load_emp_details()
        {
            string connectionString = Database.ConnectionString;

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Employee";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    guna2DataGridView_emp_details.DataSource = dt;
                }
            }
        }

        

        private void guna2Button_add_emp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add employess via admin portal.");
            this.Hide();
        }

        private void guna2DataGridView_emp_details_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in guna2DataGridView_emp_details.Columns)
            {
                col.HeaderText = col.HeaderText.Replace("_", " ");
            }
        }

        private void guna2DataGridView_viewproduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewColumn col in guna2DataGridView_viewproduct.Columns)
            {
                col.HeaderText = col.HeaderText.Replace("_", " ");
            }

        }





        private void guna2Button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
