using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;



namespace Saphire_tradex
{
    public partial class Form_bill : Form
    {

        //private double total;
        private double adder;
        public Form_bill()
        {
            InitializeComponent();

            guna2DataGridView_cusbill.Columns[2].DefaultCellStyle.Format = "N2"; // index 2 = third column = price
        }

        [DllImport("user32.dll")]
        private static extern bool PrintWindow(
     IntPtr hWnd,
     IntPtr hdcBlt,
     uint nFlags
 );

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(
            IntPtr hWnd,
            out RECT lpRect
        );

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private Bitmap CaptureFormAsImage()
        {
            GetClientRect(this.Handle, out RECT rect);

            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;

            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                IntPtr hdc = g.GetHdc();

                PrintWindow(this.Handle, hdc, 1);

                g.ReleaseHdc(hdc);
            }

            return bmp;
        }
        public void AddBillLine(string productName, int quantity, double price)
        {
          //  guna2DataGridView_cusbill.Columns["price"].DefaultCellStyle.Format = "F2";

            guna2DataGridView_cusbill.Rows.Add(productName, quantity, price);
            
        }

        
        // In Form_bill.cs
        
        public void Setdiscount(double discount)
        {
            label_discount.Text = discount.ToString("N2");
            adder = discount;
        }
        public void SetTotal(double total)
        {
            label_tot.Text = (total + (adder)).ToString("N2");
        }

        public void Set_balance(double balance,double cash)
        {
            label_bal.Text = balance.ToString("N2");
            label_cahsh.Text = cash.ToString("N2");
        }

        public void Set_Net_toal(double total)
        {
            label_net_total.Text = total.ToString("N2");
        }
        private void Form_bill_Load(object sender, EventArgs e)
        {
            label_BillID.Text= Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("hh:mm");
            label_date.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = CaptureFormAsImage())
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png";
                    sfd.FileName = "Invoice_" + label_BillID.Text + ".png";
                    sfd.Title = "Save Invoice";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(sfd.FileName, ImageFormat.Png);

                        MessageBox.Show(
                            "Invoice saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
        }

        
    }




        // public void ClearBill()
        // {
        //     guna2DataGridView_cusbill.Rows.Clear();
        // }
    
}