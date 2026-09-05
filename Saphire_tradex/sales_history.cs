using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saphire_tradex
{
    public partial class sales_history : UserControl
    {
        public sales_history()
        {
            InitializeComponent();
        }

        private void sales_history_Load(object sender, EventArgs e)
        {
            load_sales_history();
        }

        /*private void load_sales_history()
        {

            string 
        = @"Data Source=NABEEL-PC; Initial Catalog=tradex; Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);


            con.Open();

            string query = "SELECT * FROM SALES order by date_purchased desc, time_purchased desc";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            guna2DataGridView_sales.DataSource = dt;
        }*/

        private void load_sales_history()
        {
            string connection = Database.ConnectionString;

            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();
             //   guna2DataGridView_sales.Columns["sales_ID"].HeaderText = "Sales ID";
                string query = "SELECT * FROM SALES ORDER BY date_purchased DESC, time_purchased DESC";

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    guna2DataGridView_sales.DataSource = dt;
                }
            }
        }

        private void guna2DataGridView_sales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in guna2DataGridView_sales.Columns)
            {
                col.HeaderText = col.HeaderText.Replace("_", " ");
            }
        }
    }
}
