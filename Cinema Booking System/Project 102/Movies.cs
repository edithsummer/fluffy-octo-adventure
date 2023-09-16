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
    public partial class Movies : Form
    {
        public static string movie1;
        public static string m1 = "creed";
        public static string m2 = "Murder Mystery 2";
        public static string m3 = "Ambush";
        public static string m4 = "Plane";

        public Movies()
        {
            InitializeComponent();
        }

        private void Movie1bx_Click(object sender, EventArgs e)
        {
           // movie1 = m1;
        }

        private void Movie2bx_Click(object sender, EventArgs e)
        {

        }

        private void Movie3bx_Click(object sender, EventArgs e)
        {

        }

        private void Movie4bx_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //THIS IS TO TRANFER THE MOVIE NAME TO NEXT PAGE 
            if (int.Parse(MovieNoTxtBox.Text) == 1)
            {
                movie1 = m1;
                Seats SeatsForm = new Seats();
                SeatsForm.Show();
            }

            else if (int.Parse(MovieNoTxtBox.Text) == 2)
            {
                movie1 = m2;
                Seats SeatsForm = new Seats();
                SeatsForm.Show();
            }

            else if (int.Parse(MovieNoTxtBox.Text) == 3)
            {
                movie1 = m3;
                Seats SeatsForm = new Seats();
                SeatsForm.Show();
            }
            else if (int.Parse(MovieNoTxtBox.Text) == 4)
            {
                movie1 = m4;
                Seats SeatsForm = new Seats();
                SeatsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int IndexInteger = 0;
            Boolean foundBoilean = false;
            string listCompareString = "";
            string textCompareString = "";

            while (!(foundBoilean) && (IndexInteger < comboBox1.Items.Count))

            {
                listCompareString = comboBox1.Items[IndexInteger].ToString().ToUpper();
                textCompareString = SearchTxtBox.Text.ToUpper();
                if (listCompareString.StartsWith(textCompareString))
                {

                    comboBox1.SelectedIndex = IndexInteger;
                    foundBoilean = true;
                }

                else
                    IndexInteger++;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
