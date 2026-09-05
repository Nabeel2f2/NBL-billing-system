using Guna.UI2.WinForms;
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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            guna2Button_history.PerformClick();
        
        }
        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
            foreach (Control control in guna2CustomGradientPanel_left.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button btn)
                {
                    if (btn!=guna2Button_log_out)
                    btn.FillColor = Color.Transparent;
                }
            }

            activeButton.FillColor = Color.AntiqueWhite;
        }
        /*private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
             Reset all buttons
            btnDashboard.FillColor = Color.FromArgb(45, 45, 48);
            btnProducts.FillColor = Color.FromArgb(45, 45, 48);
            btnEmployees.FillColor = Color.FromArgb(45, 45, 48);
            btnSuppliers.FillColor = Color.FromArgb(45, 45, 48);

            // Highlight the selected button
            activeButton.FillColor = Color.AntiqueWhite;
        }*/

        public void LoadUserControl(UserControl userControl)
        {
            guna2Panel_emp.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            guna2Panel_emp.Controls.Add(userControl);
        }

        public void LoadUserControl_about(UserControl cc)
        {
            guna2Panel_emp.Controls.Clear();
            cc.Dock = DockStyle.None;   // keep original size
            cc.Location = new Point(0, 0); // position inside panel
            guna2Panel_emp.Controls.Add(cc);



            cc.Location = new Point(
        (guna2Panel_emp.Width - cc.Width) / 2,
        (guna2Panel_emp.Height - cc.Height) / 2);
        }
        
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadUserControl(new employee());
        }

        /*private void guna2Button_history_MouseHover(object sender, EventArgs e)
        {
            guna2Button_history.HoverState.FillColor = Color.FromArgb(230, 230, 230);
            
        }*/

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           SetActiveButton(guna2Button3);
            Dashboard uc = new Dashboard();
            LoadUserControl(uc);
        }

        private void guna2Button_emp_Click_1(object sender, EventArgs e)
        {
            SetActiveButton(guna2Button_emp);
            employee uc = new employee();
            LoadUserControl(uc);
        }

        private void guna2Button_log_out_Click(object sender, EventArgs e)
        {
            Form_dashboard zz=new Form_dashboard();
            zz.Show();
            this.Hide();
        }

        private void guna2Button_history_Click(object sender, EventArgs e)
        {
            SetActiveButton(guna2Button_history);
            sales_history sal=new sales_history();
            LoadUserControl(sal);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SetActiveButton(guna2Button2);
            UserControl_spent dtc= new UserControl_spent();
            LoadUserControl(dtc);

        }

        
        private void guna2Button_about_Click(object sender, EventArgs e)
        {
           SetActiveButton(guna2Button_about);
            UserControl_about esx = new UserControl_about();
            LoadUserControl_about(esx);
        }

       
      /*  private void rename(object sender, EventArgs e)
        {
            dataGridView1.Columns["first_name"].HeaderText = "First Name";
        }


        
private void guna2Button_history_Click(object sender, EventArgs e)
{
guna2Button_history.FillColor = Color.FromArgb(210, 210, 210);
}

private void guna2Button5_Click_1(object sender, EventArgs e)
{
guna2Button_history.FillColor = Color.FromArgb(210, 210, 210);
}*/
    }
}
