using Guna.UI2.WinForms;
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
using System.Xml.Linq;

namespace Saphire_tradex
{
    public partial class Form_dashboard : Form
    {
        public Form_dashboard()
        {
            InitializeComponent();
        }

       // double discount;
       
        private void guna2TextBox_search11_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(guna2TextBox_search11.Text))
            {
                dgvProducts.Visible = false;
                guna2DataGridView_bill_list.Visible = true;
                return;
            }
            try
            {
                dgvProducts.Visible = true;
                guna2DataGridView_bill_list.Visible = false;

                string connection= Database.ConnectionString;

                SQLiteConnection con = new SQLiteConnection(connection);

                string query = @"SELECT Product_ID, Product_Name, selling_price
                     FROM products
                     WHERE Product_Name LIKE @name";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@name",
                    guna2TextBox_search11.Text + "%"
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProducts.DataSource = dt;

                dgvProducts.Columns["selling_price"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /* private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
     {
         string productName = dgvProducts.Rows[e.RowIndex]
                              .Cells["Product_Name"].Value.ToString();

         guna2DataGridView_bill_list.Text = productName;
         dgvProducts.Visible = false;
         guna2DataGridView_bill_list.Visible = true;
     }*/
        private Form_bill billForm;
        //private Form_bill dis;
        double tot;
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                guna2DataGridView_bill_list.Columns["selling_price"].DefaultCellStyle.Format = "N2";
                guna2DataGridView_bill_list.Columns["Product_total"].DefaultCellStyle.Format = "N2";
                string id = dgvProducts.Rows[e.RowIndex].Cells["Product_ID"].Value.ToString();
                string name = dgvProducts.Rows[e.RowIndex].Cells["Product_Name"].Value.ToString();
                double price = Convert.ToDouble(dgvProducts.Rows[e.RowIndex].Cells["selling_price"].Value);
                int quantity = 1;     //Convert.ToInt32(guna2TextBox_display.Text);
                double product_total=quantity*price;
                tot += product_total;
                label_total.Text = tot.ToString("F2");
                //billForm.Total = tot;
                // In Form_dashboard.cs
               // billForm.SetTotal(tot);
                dgvProducts.Visible = false;
                guna2DataGridView_bill_list.Visible = true;
                guna2DataGridView_bill_list.Rows.Add(id, name, price,quantity,product_total);
                guna2TextBox_search11.Clear();
                guna2DataGridView_bill_list.ClearSelection();


            }
        }
        
        
        




        
       

        

        private void guna2TextBox_search11_Click(object sender, EventArgs e)
        {
            guna2TextBox_search11.Clear();
        }

        private void guna2Button_remove_all_Click(object sender, EventArgs e)
        {
            guna2DataGridView_bill_list.Rows.Clear();
            tot = 0;
            label_total.Text = tot.ToString();
            label_total.Text = "";
            label_balance.Text = "";
            label_tot_dis.Text = "";
            guna2TextBox_payment.Text = "";
        }
        double balance;
        private void guna2TextBox_payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider_payment.Clear();

                if (string.IsNullOrWhiteSpace(guna2TextBox_payment.Text))
                {
                    errorProvider_payment.SetError(guna2TextBox_payment, "Payment cannot be empty");
                }
                else
                {

                    balance = (Convert.ToDouble(guna2TextBox_payment.Text)) - tot;
                    label_balance.Text = balance.ToString("F2");
                    double payment = Convert.ToDouble(guna2TextBox_payment.Text);
                    billForm.Set_balance(balance, payment);

                }

            }
        }

        

        private void guna2TextBox_payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button_quantity_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView_bill_list.SelectedRows.Count > 0)
            {
                guna2Panel_Numpad.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void guna2Panel_Numpad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button_num0_Click(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            guna2TextBox_display.Text += btn.Text;
        }

        private void ClearErrors(object sender, EventArgs e)
        {
            if (sender != guna2Button_search)
            {
                errorProvider_search.Clear();
            }
        }

        private void ClearErrors_paymnet(object sender, EventArgs e)
        {
            if (sender != guna2TextBox_payment)
            {
                errorProvider_payment.Clear();
            }
        }

        private void Form_dashboard_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += ClearErrors;
                ctrl.Click += ClearErrors_paymnet;
            }
        }

        private void guna2Button_del_Click(object sender, EventArgs e)
        {
            guna2TextBox_display.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel_Numpad.Visible=false;
        }

        private void guna2Button_barcode_Click(object sender, EventArgs e)
        {
            guna2TextBox_search11.Text = "Enter Product ID";
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button_ent_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2Button_ent_Click_1(object sender, EventArgs e)
        {
            guna2Panel_Numpad.Visible = false;
            DataGridViewRow row = guna2DataGridView_bill_list.SelectedRows[0];

            //decimal price = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells["selling_price"].Value);


            double price = Convert.ToDouble(row.Cells["selling_price"].Value);

            int quantity = Convert.ToInt32(guna2TextBox_display.Text);

            double product_total = price * (quantity-1);

            tot += product_total;
            label_total.Text = tot.ToString("N2");


            row.Cells["quantitytt"].Value = quantity;
            row.Cells["Product_total"].Value = price*quantity;


            
            guna2Panel_Numpad.Visible = false;

            //CalculateNetTotal();
        }

        private void guna2Button_discount_Click(object sender, EventArgs e)
        {
            guna2Panel_discount.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel_discount.Visible = false;
        }
        
        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (double.TryParse(guna2TextBox_discount.Text, out double discount))
                {
                    tot -= (double)discount;
                    label_total.Text = tot.ToString("N2");
                    guna2Panel_discount.Visible = false;
                    label_tot_dis.Text = discount.ToString("F2");
                    //MessageBox.Show(discount);
                    if (billForm== null || billForm.IsDisposed)
                    {billForm= new Form_bill();
                    }
                    billForm.Setdiscount(discount);
                }
                else
                {
                    MessageBox.Show("Please enter a valid discount.");
                }
            }
        }
        

        private void guna2Button_enter_Click(object sender, EventArgs e)
        {
            
            string connection = Database.ConnectionString;
            MessageBox.Show("Sale saved Successfully.");
            if (billForm == null || billForm.IsDisposed)
            {
                billForm = new Form_bill();
                //billForm.Show();
            }
            billForm.SetTotal(tot);
            billForm.Set_Net_toal(tot);


            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                foreach (DataGridViewRow row in guna2DataGridView_bill_list.Rows)
                {
                    if (row.IsNewRow)
                        continue;
                    //guna2DataGridView_cusbill.Columns["pi"].DefaultCellStyle.Format = "N2";
                    string salesID = Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
                    string productID = row.Cells["Product_ID"].Value.ToString();
                    string productName = row.Cells["Product_Name"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantitytt"].Value);
                    double price = Convert.ToDouble(row.Cells["product_total"].Value);

                    string query = @"INSERT INTO sales
                    (sales_ID, Product_Name, Product_ID, quantity, price, date_purchased, time_purchased)
                    VALUES
                    (@sid, @pname, @pid, @qty, @price, @date, @time)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@sid", salesID);
                        cmd.Parameters.AddWithValue("@pname", productName);
                        cmd.Parameters.AddWithValue("@pid", productID);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));

                        cmd.ExecuteNonQuery();
                    }

                    billForm.AddBillLine(productName, quantity, price);
                }
            }

            guna2Button_viewbill.Visible = true;
            
            guna2DataGridView_bill_list.Rows.Clear();
            label_total.Text = "";
            label_balance.Text = "";
            label_tot_dis.Text = "";
            guna2TextBox_payment.Text = "";
        }

        private void guna2Button_card_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perform transaction via credit/debit cards");
        }

        private void guna2Button_search_Click(object sender, EventArgs e)
        {
            errorProvider_search.Clear();

            if (string.IsNullOrWhiteSpace(guna2TextBox_search11.Text))
            {
                errorProvider_search.SetError(guna2TextBox_search11, "Product cannot be empty");
            }
            else
            {
                errorProvider_search.SetError(guna2TextBox_search11, "");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label_date.Text = DateTime.Now.ToString("dd/MM/yy");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin123";
            form_login zzx = new form_login(username, password);            
            zzx.Show();
            this.Hide();
        }

        private void guna2Button_remove_one_Click_1(object sender, EventArgs e)
        {
            
            if (guna2DataGridView_bill_list.SelectedRows.Count > 0)
            {
                DataGridViewRow row = guna2DataGridView_bill_list.SelectedRows[0];
                double removedTotal = Convert.ToDouble(row.Cells["Product_total"].Value);
                guna2DataGridView_bill_list.Rows.Remove(
                    guna2DataGridView_bill_list.SelectedRows[0]
                );

                
                tot -= removedTotal;
                label_total.Text = tot.ToString("F2");

            }
            else
            {
                MessageBox.Show("Please select an item to remove");
            }

        }


        

        private void guna2DataGridView_bill_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button_viewbill_Click(object sender, EventArgs e)
        {
            if (billForm != null && !billForm.IsDisposed)
            {
                billForm.Show();
                billForm.BringToFront();
            }
            else
            {
                MessageBox.Show("No bill available yet.");
            }
        }
    }

}
