namespace Saphire_tradex
{
    partial class Form_bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_bill));
            this.label_net_total = new System.Windows.Forms.Label();
            this.label_BillID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_tot = new System.Windows.Forms.Label();
            this.label3_discount = new System.Windows.Forms.Label();
            this.label3_total = new System.Windows.Forms.Label();
            this.guna2DataGridView_cusbill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Qunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_bala = new System.Windows.Forms.Label();
            this.label_cash = new System.Windows.Forms.Label();
            this.label_cahsh = new System.Windows.Forms.Label();
            this.label_bal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_cusbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_net_total
            // 
            this.label_net_total.AutoSize = true;
            this.label_net_total.BackColor = System.Drawing.Color.White;
            this.label_net_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_net_total.Location = new System.Drawing.Point(211, 521);
            this.label_net_total.Name = "label_net_total";
            this.label_net_total.Size = new System.Drawing.Size(79, 29);
            this.label_net_total.TabIndex = 16;
            this.label_net_total.Text = "label3";
            // 
            // label_BillID
            // 
            this.label_BillID.AutoSize = true;
            this.label_BillID.BackColor = System.Drawing.Color.White;
            this.label_BillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BillID.Location = new System.Drawing.Point(304, 124);
            this.label_BillID.Name = "label_BillID";
            this.label_BillID.Size = new System.Drawing.Size(58, 22);
            this.label_BillID.TabIndex = 15;
            this.label_BillID.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.White;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(297, 147);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(58, 22);
            this.label_time.TabIndex = 14;
            this.label_time.Text = "label4";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.White;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(76, 147);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(58, 22);
            this.label_date.TabIndex = 13;
            this.label_date.Text = "label4";
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.BackColor = System.Drawing.Color.White;
            this.label_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.Location = new System.Drawing.Point(260, 422);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(0, 29);
            this.label_discount.TabIndex = 12;
            // 
            // label_tot
            // 
            this.label_tot.AutoSize = true;
            this.label_tot.BackColor = System.Drawing.Color.White;
            this.label_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tot.Location = new System.Drawing.Point(258, 398);
            this.label_tot.Name = "label_tot";
            this.label_tot.Size = new System.Drawing.Size(0, 29);
            this.label_tot.TabIndex = 11;
            // 
            // label3_discount
            // 
            this.label3_discount.AutoSize = true;
            this.label3_discount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3_discount.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_discount.Location = new System.Drawing.Point(24, 425);
            this.label3_discount.Name = "label3_discount";
            this.label3_discount.Size = new System.Drawing.Size(103, 30);
            this.label3_discount.TabIndex = 10;
            this.label3_discount.Text = "Discount";
            // 
            // label3_total
            // 
            this.label3_total.AutoSize = true;
            this.label3_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3_total.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_total.Location = new System.Drawing.Point(24, 400);
            this.label3_total.Name = "label3_total";
            this.label3_total.Size = new System.Drawing.Size(64, 30);
            this.label3_total.TabIndex = 9;
            this.label3_total.Text = "Total";
            // 
            // guna2DataGridView_cusbill
            // 
            this.guna2DataGridView_cusbill.AllowUserToAddRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_cusbill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_cusbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.guna2DataGridView_cusbill.ColumnHeadersHeight = 18;
            this.guna2DataGridView_cusbill.ColumnHeadersVisible = false;
            this.guna2DataGridView_cusbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qunatity,
            this.Price,
            this.Total});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_cusbill.DefaultCellStyle = dataGridViewCellStyle24;
            this.guna2DataGridView_cusbill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_cusbill.Location = new System.Drawing.Point(36, 210);
            this.guna2DataGridView_cusbill.Name = "guna2DataGridView_cusbill";
            this.guna2DataGridView_cusbill.RowHeadersVisible = false;
            this.guna2DataGridView_cusbill.RowHeadersWidth = 51;
            this.guna2DataGridView_cusbill.RowTemplate.Height = 24;
            this.guna2DataGridView_cusbill.Size = new System.Drawing.Size(329, 187);
            this.guna2DataGridView_cusbill.TabIndex = 8;
            this.guna2DataGridView_cusbill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_cusbill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView_cusbill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView_cusbill.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView_cusbill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView_cusbill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView_cusbill.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView_cusbill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Qunatity
            // 
            this.Qunatity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Qunatity.FillWeight = 25F;
            this.Qunatity.Frozen = true;
            this.Qunatity.HeaderText = "Quantity";
            this.Qunatity.MinimumWidth = 6;
            this.Qunatity.Name = "Qunatity";
            this.Qunatity.Width = 99;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.FillWeight = 25F;
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 85;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.FillWeight = 50F;
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 91;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(15, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(364, 621);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(278, 648);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(109, 37);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(150, 180);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(100, 29);
            this.label_amount.TabIndex = 18;
            this.label_amount.Text = "Quantity";
            // 
            // label_bala
            // 
            this.label_bala.AutoSize = true;
            this.label_bala.BackColor = System.Drawing.Color.White;
            this.label_bala.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bala.Location = new System.Drawing.Point(24, 479);
            this.label_bala.Name = "label_bala";
            this.label_bala.Size = new System.Drawing.Size(92, 30);
            this.label_bala.TabIndex = 19;
            this.label_bala.Text = "Balance";
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cash.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cash.Location = new System.Drawing.Point(26, 450);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(62, 30);
            this.label_cash.TabIndex = 20;
            this.label_cash.Text = "Cash";
            // 
            // label_cahsh
            // 
            this.label_cahsh.AutoSize = true;
            this.label_cahsh.BackColor = System.Drawing.Color.White;
            this.label_cahsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cahsh.Location = new System.Drawing.Point(258, 449);
            this.label_cahsh.Name = "label_cahsh";
            this.label_cahsh.Size = new System.Drawing.Size(79, 29);
            this.label_cahsh.TabIndex = 21;
            this.label_cahsh.Text = "label3";
            // 
            // label_bal
            // 
            this.label_bal.AutoSize = true;
            this.label_bal.BackColor = System.Drawing.Color.White;
            this.label_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bal.Location = new System.Drawing.Point(258, 478);
            this.label_bal.Name = "label_bal";
            this.label_bal.Size = new System.Drawing.Size(79, 29);
            this.label_bal.TabIndex = 22;
            this.label_bal.Text = "label3";
            // 
            // Form_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(397, 690);
            this.Controls.Add(this.label_bal);
            this.Controls.Add(this.label_cahsh);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.label_bala);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label_net_total);
            this.Controls.Add(this.label_BillID);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label_tot);
            this.Controls.Add(this.label3_discount);
            this.Controls.Add(this.label3_total);
            this.Controls.Add(this.guna2DataGridView_cusbill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_bill";
            this.Text = "Customer Bill";
            this.Load += new System.EventHandler(this.Form_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_cusbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_net_total;
        private System.Windows.Forms.Label label_BillID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_tot;
        private System.Windows.Forms.Label label3_discount;
        private System.Windows.Forms.Label label3_total;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_cusbill;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label_bala;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.Label label_cahsh;
        private System.Windows.Forms.Label label_bal;
    }
}