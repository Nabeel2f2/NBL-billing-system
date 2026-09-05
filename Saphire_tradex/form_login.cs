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
    public partial class form_login : Form
    {
        private string username;
        private string password;

        public form_login(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void label_Role_Click(object sender, EventArgs e)
        {

        }

        private void label_paswoed_Click(object sender, EventArgs e)
        {

        }

        

        private void form_login_Load(object sender, EventArgs e)
        {
            guna2ComboBox_role.SelectedIndex = 0;

        }

        private void guna2TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text1 = guna2TextBox_username.Text;
                string text2 = guna2TextBoxPassword.Text;
                if (guna2ComboBox_role.SelectedIndex == 0)
                {
                    if (text1 == username && text2 == password)
                    {

                        Form_Admin zxc = new Form_Admin();
                        zxc.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Username or password is incorrect.");
                    }
                }
                else if (guna2ComboBox_role.SelectedIndex == 1)
                {
                    if (text1 == "cashier1" && text2 == "asdf321")
                    {
                        Form_dashboard wer = new Form_dashboard();
                        wer.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Username or password is incorrect.");
                    }
                }
            }
        }

      

        

        

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        

        private void linkLabel_forgot_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guna2Panel_secret.Visible = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form_new_setup ccc = new Form_new_setup();
            this.Hide();
            ccc.Show();
        }

        private void guna2Button_secret_ent_Click_1(object sender, EventArgs e)
        {
            if(guna2TextBox_secret_code.Text == "9078320")
            {
                MessageBox.Show("Reset your password from Admin portal.");
                Form_Admin yh = new Form_Admin();
                yh.Show();
            }
            else
            {
                MessageBox.Show("secret code is invalid.");
            }
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            guna2Panel_secret.Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button_continue_Click_1(object sender, EventArgs e)
        {
            string text1 = guna2TextBox_username.Text;
            string text2 = guna2TextBoxPassword.Text;
            if (guna2ComboBox_role.SelectedIndex == 0)
            {
                if (text1 == username && text2 == password)
                {

                    Form_Admin zxc = new Form_Admin();
                    zxc.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            else if (guna2ComboBox_role.SelectedIndex == 1)
            {
                if (text1 == "cashier1" && text2 == "asdf321")
                {
                    Form_dashboard wer = new Form_dashboard();
                    wer.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Username or password is incorrect.");
                }
            }
        }
    }
}
