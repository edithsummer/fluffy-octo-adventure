using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_102
{
    public partial class Total : Form
    {
        double TotalVAT;
        double Amount;
        double Change;

        public Total()
        {
            InitializeComponent();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {

                TotalVAT = double.Parse(TotalTxtBox.Text);
                Amount = double.Parse(AmountTxtBox.Text);
                if (Amount >= TotalVAT)
                {
                    Change = Amount - TotalVAT;
                    ChangeTxtBox.Text = Change.ToString("C");

                }
                else
                {
                    MessageBox.Show("Please enter an appropriate amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
             



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Back3btn_Click(object sender, EventArgs e)
        {
            Seats SeatsForm = new Seats();
            SeatsForm.Show();
        }

        private void Checkout3btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm3btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your tickets have been booked, Thank you","Confirmed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            ReceiptTxtbx.Text += "Total+VAT:"+TotalTxtBox.Text + Environment.NewLine;
            ReceiptTxtbx.Text += "Change:" + ChangeTxtBox.Text + Environment.NewLine;
            ReceiptTxtbx.Text += "........................................................." + Environment.NewLine;
            ReceiptTxtbx.Text += "Thank you for choosing Cinema name , Enjoy !";
            
        }

        private void Total_Load(object sender, EventArgs e)
        {
            TotalTxtBox.Text = Seats.Total2.ToString("C");


            ReceiptTxtbx.Text += "Name of cinema" + Environment.NewLine;
            ReceiptTxtbx.Text += "........................................................." + Environment.NewLine;
            ReceiptTxtbx.Text += "Name:" + Login.FirstName + Environment.NewLine;
            ReceiptTxtbx.Text += "Surname:" + Login.Surname + Environment.NewLine;
            ReceiptTxtbx.Text += "Ticket No.: 1" + Environment.NewLine;
            ReceiptTxtbx.Text += Movies.movie1+Environment.NewLine;
            ReceiptTxtbx.Text += "Seat Numbers:" + Seats.selectedSeats + Environment.NewLine;
            ReceiptTxtbx.Text += "........................................................." + Environment.NewLine;
            ReceiptTxtbx.Text += "Date:=" + DateTime.Now + Environment.NewLine;
            ReceiptTxtbx.Text += "Venue: Cinema 1" + Environment.NewLine + " Show Time : 3:00 PM "+Environment.NewLine;
            ReceiptTxtbx.Text += "........................................................." + Environment.NewLine;
            

        }

        private void ReceiptTxtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AmountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
