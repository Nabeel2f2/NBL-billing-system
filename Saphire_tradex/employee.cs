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
    public partial class employee : UserControl
    {
        public employee()
        {
            InitializeComponent();
          
        }




        /*private void guna2Button_submit_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=NABEEL-PC; Initial Catalog=tradex; Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string adding = "insert into employee values('" +
                guna2ComboBox_emp_role.Text + "','" +
                guna2TextBox_emp_id.Text + "','" +
                guna2TextBox_emp_name.Text + "','" +
                guna2ComboBox_sex.Text+ "','" +
                Convert.ToInt32(guna2TextBox_age.Text) + "','" +
                guna2TextBox_tel.Text + "','" +
                guna2TextBox_adres.Text + "','"+
                Convert.ToDouble(guna2TextBoxsalary.Text) + "','" +
                guna2ComboBox_days.Text+"')";
            SqlCommand ss = new SqlCommand(adding, con);
            ss.ExecuteNonQuery();
            MessageBox.Show("Details entered successfully.");
        }*/
        private Form_product_table upd_count;
        private void UpdateEmployeeCount()
        {
            string connection = Database.ConnectionString;
            long count = 0;
            long cashierCount = 0; // separate variable name for the second count
            long man_count = 0;

            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                string countQuery = "SELECT COUNT(*) FROM employee";
                string count_Emp = "SELECT COUNT(*) FROM employee WHERE TRIM(role) = @role COLLATE NOCASE";
               // string count_man = "SELECT COUNT(*) FROM employee WHERE TRIM(role) = @man COLLATE NOCASE";

                using (SQLiteCommand cmd = new SQLiteCommand(countQuery, con))
                {
                    count = (long)cmd.ExecuteScalar();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(count_Emp, con)) // fixed casing to match declaration
                {
                    cmd.Parameters.AddWithValue("@role", "Cashier");
                    cashierCount = (long)cmd.ExecuteScalar(); // assign to the new variable, don't redeclare "count"
                }

                using (SQLiteConnection nbl = new SQLiteConnection(connection))
                {
                    nbl.Open();
                    string count_man = "SELECT COUNT(*) FROM employee WHERE TRIM(role) = @role COLLATE NOCASE";

                    using (SQLiteCommand cmd = new SQLiteCommand(count_man, nbl)) // fixed casing to match declaration
                    {
                        cmd.Parameters.AddWithValue("@role", "Salesman");
                        man_count = (long)cmd.ExecuteScalar(); // assign to the new variable, don't redeclare "count"
                        //MessageBox.Show("man_count query result: " + man_count.ToString());
                    }
                }

                // labels updated after the using blocks close, same as your existing pattern
                if (upd_count != null && !upd_count.IsDisposed)
                {
                    upd_count.SetEmployeeCount(count);
                    // you'll also need a method on Form_product_table to receive cashierCount, e.g.:
                    upd_count.SetCashierCount(cashierCount);
                    upd_count.Setmancount(man_count);
                }
            }
        }
        
        private void guna2Button_submit_Click(object sender, EventArgs e)
        {
            string role = guna2ComboBox_emp_role.Text.Trim();
                    
            string connection = Database.ConnectionString;
            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                string adding = @"INSERT INTO employee
                 (role, emp_ID, emp_name, sex, age, telephone_Number, addres, salary, working_days)
                 VALUES
                 (@role, @id, @name, @sex, @age, @tel, @adres, @salary, @days)";

                using (SQLiteCommand ss = new SQLiteCommand(adding, con))
                {
                    ss.Parameters.AddWithValue("@role", role); // use the validated variable, not guna2ComboBox_emp_role.Text directly
                    ss.Parameters.AddWithValue("@id", guna2TextBox_emp_id.Text);
                    ss.Parameters.AddWithValue("@name", guna2TextBox_emp_name.Text);
                    ss.Parameters.AddWithValue("@sex", guna2ComboBox_sex.Text);
                    ss.Parameters.AddWithValue("@age", Convert.ToInt32(guna2TextBox_age.Text));
                    ss.Parameters.AddWithValue("@tel", guna2TextBox_tel.Text);
                    ss.Parameters.AddWithValue("@adres", guna2TextBox_adres.Text);
                    ss.Parameters.AddWithValue("@salary", Convert.ToDouble(guna2TextBoxsalary.Text));
                    ss.Parameters.AddWithValue("@days", guna2ComboBox_days.Text);

                    ss.ExecuteNonQuery();
                }
            }

            UpdateEmployeeCount();          
            MessageBox.Show("Details entered successfully.");

            if (upd_count != null && !upd_count.IsDisposed)
            {
                upd_count.Load_emp_details();
            }
        }
        

        /* private void RefreshEmployeeCount()
         {
             using (SQLiteConnection con = new SQLiteConnection(Database.ConnectionString))
             {
                 con.Open();
                 string countQuery = "SELECT COUNT(*) FROM employee";

                 using (SQLiteCommand cmd = new SQLiteCommand(countQuery, con))
                 {
                     long count = (long)cmd.ExecuteScalar();

                 }
             }
         }*/
        private void guna2Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox_emp_id.Text == "")
                {
                    MessageBox.Show("Please enter employee ID");
                }
                else
                {
                    string connection = Database.ConnectionString;

                    using (SQLiteConnection con = new SQLiteConnection(connection))
                    {
                        con.Open();

                        string sql = "DELETE FROM Employee WHERE emp_ID = @emp_ID";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@emp_ID", guna2TextBox_emp_id.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Employee deleted successfully.");
                    if (upd_count != null && !upd_count.IsDisposed)
                    {
                        upd_count.RefreshEmployeeCount();
                        UpdateEmployeeCount();
                        upd_count.Load_emp_details();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button_view_Click(object sender, EventArgs e)
        {
            if (upd_count == null || upd_count.IsDisposed)
            {
                upd_count = new Form_product_table("details");
                upd_count.Show();
                UpdateEmployeeCount();
                
               // upd_count.RefreshEmployeeCount() ;
            }
            else
            {                
                upd_count.Show();
                upd_count.BringToFront();
                upd_count.RefreshEmployeeCount(); // calling the method ON the other form's object
            }
        }



        private void guna2Button1_clear_Click(object sender, EventArgs e)
        {
            guna2ComboBox_emp_role.Text = "";
            guna2TextBox_emp_id.Text = "";
            guna2TextBox_emp_name.Text = "";
            guna2ComboBox_sex.Text = "";
            guna2TextBox_age.Text = "";
            guna2TextBox_tel.Text = "";
            guna2TextBox_adres.Text = "";
            guna2TextBoxsalary.Text = "";
            guna2ComboBox_days.Text = "";
        }

     
    }
}
