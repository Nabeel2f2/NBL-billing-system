using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saphire_tradex
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button_submit_Click(object sender, EventArgs e)
        {
            


        }

        private void guna2Button_clear_Click(object sender, EventArgs e)
        {
           
        }


        private void guna2TextBox_product_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button_update_Click(object sender, EventArgs e)
        {
            
        }
       
        
        

        private void guna2Button_view_Click_1(object sender, EventArgs e)
        {
            Form_product_table rt= new Form_product_table("Product");
            rt.Show();
        }

         

        private void guna2Button_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox_product_id.Text == "")
                {
                    MessageBox.Show("Please enter product ID");
                }
                else
                {
                    string connection = Database.ConnectionString;
                    /* SqlConnection con = new SqlConnection(connection);
                     con.Open();
                     string sql = "delete from Products where Product_ID='" + guna2TextBox_product_id.Text + "'";

                     SqlCommand con2 = new SqlCommand(sql, con);
                     con2.ExecuteNonQuery();
                     MessageBox.Show("Product deleted successfully.");
                     con.Close();*/



                    using (SQLiteConnection con = new SQLiteConnection(connection))
                    {
                        con.Open();

                        string sql = "DELETE FROM products WHERE Product_ID = @emp_ID";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@emp_ID", guna2TextBox_product_id.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product deleted successfully.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* private void guna2Button_submit_Click_1(object sender, EventArgs e)
        {
            string connection = @"Data Source=NABEEL-PC; Initial Catalog=tradex; Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string adding = "insert into Products values('" +
                guna2TextBox_product_id.Text + "','" +
                guna2TextBox_name.Text + "','" +
                Convert.ToDecimal(guna2TextBox_buying_price.Text) + "','" +
                Convert.ToDecimal(guna2TextBox_selling_price.Text) + "','" +
                guna2TextBox_produc_date.Text + "','" +
                guna2TextBox_exp_date.Text + "','" +
                Convert.ToDecimal(guna2TextBox_weight.Text) + "')";
            SqlCommand ss = new SqlCommand(adding, con);
            ss.ExecuteNonQuery();
            MessageBox.Show("Details entered successfully.");
        }*/


        private void guna2Button_submit_Click_1(object sender, EventArgs e)
        {
            string connection = Database.ConnectionString;

            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();
                string adding = @"insert into Products
	            (product_id,product_name,buying_price,selling_price,production_date,expired_date,weightt)
	            values
	            (@id,@name,@b_price,@sel_price,@pr_date,@exp_date,@weight)";



                /* string adding = "insert into Products values('" +
                     guna2TextBox_product_id.Text + "','" +
                     guna2TextBox_name.Text + "','" +
                     Convert.ToDecimal(guna2TextBox_buying_price.Text) + "','" +
                     Convert.ToDecimal(guna2TextBox_selling_price.Text) + "','" +
                     guna2TextBox_produc_date.Text + "','" +
                     guna2TextBox_exp_date.Text + "','" +
                     Convert.ToDecimal(guna2TextBox_weight.Text) + "')";*/
                using (SQLiteCommand ss = new SQLiteCommand(adding, con))
                {
                    ss.Parameters.AddWithValue("@id", guna2TextBox_product_id.Text);
                    ss.Parameters.AddWithValue("@name", guna2TextBox_name.Text);
                    ss.Parameters.AddWithValue("@b_price", Convert.ToDecimal(guna2TextBox_buying_price.Text));
                    ss.Parameters.AddWithValue("@sel_price", Convert.ToDecimal(guna2TextBox_selling_price.Text));
                    ss.Parameters.AddWithValue("@pr_date", guna2TextBox_produc_date.Text);
                    ss.Parameters.AddWithValue("@exp_date", guna2TextBox_exp_date.Text);
                    ss.Parameters.AddWithValue("@weight", Convert.ToDecimal(guna2TextBox_weight.Text));

                    ss.ExecuteNonQuery();
                }
                MessageBox.Show("Details entered successfully.");
            }
        }





        private void guna2Button_clear_Click_1(object sender, EventArgs e)
        {
            guna2TextBox_product_id.Text = "";
            guna2TextBox_name.Text = "";
            guna2TextBox_buying_price.Text = "";
            guna2TextBox_selling_price.Text = "";
            guna2TextBox_produc_date.Text = "";
            guna2TextBox_exp_date.Text = "";
            guna2TextBox_weight.Text = "";
        }

        /*private void guna2Button_update_Click_1(object sender, EventArgs e)
        {
            string connection = @"Data Source=NABEEL-PC;Initial Catalog=tradex;Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string sql = "UPDATE products SET " +
                         "Product_Name='" + guna2TextBox_name.Text + "'," +
                         "buying_price='" + guna2TextBox_buying_price.Text + "'," +
                         "selling_price='" + guna2TextBox_selling_price.Text + "'," +
                         "production_date='" + guna2TextBox_produc_date.Text + "'," +
                         "expired_date='" + guna2TextBox_exp_date.Text + "'," +
                         "weightt='" + guna2TextBox_weight.Text + "' " +
                         "WHERE Product_ID='" + guna2TextBox_product_id.Text + "'";

            SqlCommand comobj = new SqlCommand(sql, con);
            comobj.ExecuteNonQuery();

            MessageBox.Show("Product updated successfully.");

            con.Close();
        }*/
        private void guna2Button_update_Click_1(object sender, EventArgs e)
        {
            string connection = Database.ConnectionString;

            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                string sql = @"UPDATE products SET
                        Product_Name=@name,
                        buying_price=@b_price,
                        selling_price=@sel_price,
                        production_date=@pr_date,
                        expired_date=@exp_date,
                        weightt=@weight
                        WHERE Product_ID=@id";

                using (SQLiteCommand comobj = new SQLiteCommand(sql, con))
                {
                    comobj.Parameters.AddWithValue("@name", guna2TextBox_name.Text);
                    comobj.Parameters.AddWithValue("@b_price", Convert.ToDecimal(guna2TextBox_buying_price.Text));
                    comobj.Parameters.AddWithValue("@sel_price", Convert.ToDecimal(guna2TextBox_selling_price.Text));
                    comobj.Parameters.AddWithValue("@pr_date", guna2TextBox_produc_date.Text);
                    comobj.Parameters.AddWithValue("@exp_date", guna2TextBox_exp_date.Text);
                    comobj.Parameters.AddWithValue("@weight", Convert.ToDecimal(guna2TextBox_weight.Text));
                    comobj.Parameters.AddWithValue("@id", guna2TextBox_product_id.Text);

                    comobj.ExecuteNonQuery();
                }

                MessageBox.Show("Product updated successfully.");
            }
        }

        private void guna2TextBox_produc_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_pd_date_Click(object sender, EventArgs e)
        {

        }
    }
}
