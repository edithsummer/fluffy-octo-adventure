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
    public partial class Seats : Form
    {
        public static double Total2;
        const double VAT = 0.15;
        public static string selectm ;
        public static string selectedSeats;
        int count = 0;
        int ticketCount;
        double Total1;
        public Seats()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ticketCount = int.Parse(textBox1.Text);
            selectedSeats = SeatsTxtBox.Text;
        
            if ((ticketCount > count)||(ticketCount < count))
            {
                MessageBox.Show("Please select the correct number of seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SeatsTxtBox.Clear();
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button24.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button29.BackColor = Color.White;
                button8.BackColor = Color.White;
                button11.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button28.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button27.BackColor = Color.White;
                button4.BackColor = Color.White;
                button23.BackColor = Color.White;
                button9.BackColor = Color.White;
                button25.BackColor = Color.White;
                button12.BackColor = Color.White;
                button10.BackColor = Color.White;
                button26.BackColor = Color.White;
                count = 0;
                Total2 = Total1 + (Total1*VAT);
                textBox3.Text = Total2.ToString("C");

            }
            else
            {
                Total TotalForm = new Total();
                TotalForm.Show();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int movieCost = 35;
            int glassCost = 20;
            int ticketsCost;
            int glassCount = 0;
            double Total1;
            
            ticketCount = int.Parse(textBox1.Text);


            if (textBox2.Text == "")
            {
                ticketsCost = movieCost*ticketCount;
                textBox3.Text = ticketsCost.ToString("C");
            }

            else
            {
                glassCount = int.Parse(textBox2.Text);
                ticketsCost = movieCost*ticketCount;
                glassCost = glassCount * glassCost;
                Total1 = (ticketsCost + glassCost);
                Total2 = Total1 + (Total1 * VAT);
                textBox3.Text = Total2.ToString("C");
            }

        }

        private void Seats_Load(object sender, EventArgs e)
        {
           MovieTxtBox.Text = Movies.movie1;

        }

        private void MovieTxtBox_TextChanged(object sender, EventArgs e)
        {
          
           

        }

        private void Back2btn_Click(object sender, EventArgs e)
        {
            Movies MoviesForm = new Movies();
            MoviesForm.Show();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D1" + Environment.NewLine;
            count = count + 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D2"+Environment.NewLine;
            count = count + 1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D3" + Environment.NewLine;
            count = count + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D4" + Environment.NewLine;
            count = count + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D5" + Environment.NewLine;
            count = count + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D6" + Environment.NewLine;
            count = count + 1;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "D7" + Environment.NewLine;
            count = count + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C1" + Environment.NewLine;
            count = count + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C2" + Environment.NewLine;
            count = count + 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C3" + Environment.NewLine;
            count = count + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C4" + Environment.NewLine;
            count = count + 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C5" + Environment.NewLine;
            count = count + 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C6" + Environment.NewLine;
            count = count + 1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "C7" + Environment.NewLine;
            count = count + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B1" + Environment.NewLine;
            count = count + 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B2" + Environment.NewLine;
            count = count + 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B3" + Environment.NewLine;
            count = count + 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B4" + Environment.NewLine;
            count = count + 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B5" + Environment.NewLine;
            count = count + 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B6" + Environment.NewLine;
            count = count + 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "B7" + Environment.NewLine;
            count = count + 1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A1" + Environment.NewLine;
            count = count + 1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A2" + Environment.NewLine;
            count = count + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A3" + Environment.NewLine;
            count = count + 1;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A4" + Environment.NewLine;
            count = count + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A5" + Environment.NewLine;
            count = count + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A6" + Environment.NewLine;
            count = count + 1;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.LightGreen;
            SeatsTxtBox.Text += "A7" + Environment.NewLine;
            count = count + 1;
        }

        private void Clear2btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            SeatsTxtBox.Clear();
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button24.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button29.BackColor = Color.White;
            button8.BackColor = Color.White;
            button11.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button28.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button27.BackColor = Color.White;
            button4.BackColor = Color.White;
            button23.BackColor = Color.White;
            button9.BackColor = Color.White;
            button25.BackColor = Color.White;
            button12.BackColor = Color.White;
            button10.BackColor = Color.White;
            button26.BackColor = Color.White;

        }

       
    }
}
