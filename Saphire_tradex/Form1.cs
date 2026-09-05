using Guna.UI2.WinForms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;



namespace Saphire_tradex
{
    public partial class Form_new_setup : Form
    {
       
        public Form_new_setup()
        {
            InitializeComponent();

        }
        

        
        

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel_fresher_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel_admin_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel_started_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_sdmart_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
            string pword= guna2TextBox_password.Text;
            string conword = guna2TextBox_password_con.Text;
            if(pword==conword)
            {
                //guna2Panel_start.Visible = false;
                //guna2Panel_emp_details.Visible = true;
                //form_login.visible = true;
                string username = guna2TextBox_username11.Text;
                string password = guna2TextBox_password_con.Text;
                form_login frm1 = new form_login(username,password);
                frm1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Your Password confirmation is wrong!");
            }

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label_header_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox_username11_MouseClick(object sender, MouseEventArgs e)
        {
            guna2TextBox_username11.Text = "";
            guna2PictureBox_username.Visible = false;
            guna2TextBox_username11.PlaceholderText = string.Empty;
        }

        private void guna2TextBox_password_MouseClick(object sender, MouseEventArgs e)
        {
            guna2PictureBox_passwprd.Visible = false;
            guna2TextBox_password.PlaceholderText = "";
        }

        private void guna2TextBox_password_con_MouseClick(object sender, MouseEventArgs e)
        {
            guna2PictureBox6_conpass.Visible = false;
            guna2TextBox_password_con.PlaceholderText = string.Empty;
        }

        private void guna2Button_eye_Click(object sender, EventArgs e)
        {
            guna2Button_eye.Visible = false;
            guna2Button_eye_hide.Visible = true;
            
            if (guna2TextBox_password.UseSystemPasswordChar)
            {
                // Show password
                guna2TextBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                guna2TextBox_password.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button_eye_hide_Click(object sender, EventArgs e)
        {
            guna2Button_eye_hide.Visible=false;
            guna2Button_eye.Visible = true;
            if (guna2TextBox_password.UseSystemPasswordChar)
            {
                // Show password
                guna2TextBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                guna2TextBox_password.UseSystemPasswordChar = true;
            }

        }

        private void guna2Button_hide_con_Click(object sender, EventArgs e)
        {
            guna2Button_hide_con.Visible = false;
            guna2Button_eye_conpa.Visible = true;
            if (guna2TextBox_password_con.UseSystemPasswordChar)
            {
                // Show password
                guna2TextBox_password_con.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                guna2TextBox_password_con.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button_eye_conpa_Click(object sender, EventArgs e)
        {
            guna2Button_hide_con.Visible = true;
            guna2Button_eye_conpa.Visible = false;
            if (guna2TextBox_password_con.UseSystemPasswordChar)
            {
                // Show password
                guna2TextBox_password_con.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                guna2TextBox_password_con.UseSystemPasswordChar = true;
            }
        }
        /*
public void OpenPage(UserControl page)
{
guna2Panel_emp_details.Controls.Clear();
page.Dock = DockStyle.Fill;
guna2Panel_emp_details.Controls.Add(page);
}


public void OpenPage(UserControl page)
{
guna2Panel1.Controls.Clear();
page.Dock = DockStyle.Fill;
guna2Panel1.Controls.Add(page);
}


private void guna2Button_emp_submit_Click(object sender, EventArgs e)
{
OpenPage(new Dashboard());
}

private void label_username_Click(object sender, EventArgs e)
{

}
/*
public void LoadUserControl(UserControl uc)
{
Dashboard.Controls.Clear();    // panelMain is the panel that holds your user controls
uc.Dock = DockStyle.Fill;
Dashboard.Controls.Add(uc);
}*/
    }
}
