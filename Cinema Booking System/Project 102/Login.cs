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
    public partial class Login : Form
    {
        public static string FirstName;
        public static string Surname;
      
        public object LoginForm { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void seatsToolStripMenuItem_Click(object sender, EventArgs e)
        {//PLEASE DO NOT ALTER CODE AS FORM WILL CRASH
            Seats SeatsForm = new Seats();
            SeatsForm.Show();
        }

        private void diagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Diagram DiagramForm = new Diagram();
            //  DiagramForm.Show();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Total TotalForm = new Total();
            //  TotalForm.Show();
        }

        private void diragramToolStripMenuItem_Click(object sender, EventArgs e)
        {  //PLEASE DO NOT ALTER CODE AS FORM WILL CRASH
           //  Select selectform = new Project_102.Select();
           // selectform.Show();
        }

        private void totalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {//PLEASE DO NOT ALTER CODE AS FORM WILL CRASH
            Total TotalForm = new Total();
            TotalForm.Show();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies MoviesForm = new Movies();
            MoviesForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Next0btn_Click(object sender, EventArgs e)
        {
            try
            {
                FirstName = NameTxtBox.Text;
                Surname = SurnameTxtBox.Text;
            }
            catch
            {
                MessageBox.Show("Please enter valid name and surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTxtBox.Clear();
                SurnameTxtBox.Clear();
            }

            FirstName = NameTxtBox.Text;
                Surname = SurnameTxtBox.Text;
                int Password = int.Parse(PasswordTxtBox.Text);

                if ((FirstName == "") && (Surname == ""))
                {
                    NameTxtBox.BackColor = Color.Red;
                    SurnameTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter Name and Surname");
                }
                else if ((FirstName == "") && (Password == -1))
                {
                    NameTxtBox.BackColor = Color.Red;
                    PasswordTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter Name and Password");
                }
                else if ((Surname == "") && (Password == -1))
                {
                    PasswordTxtBox.BackColor = Color.Red;
                    SurnameTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter  Password and Surname");
                }
                else if (Password == -1)
                {

                    PasswordTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter password");
                }
                else if (Surname == "")
                {
                    SurnameTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter Surname");
                }
                else if (FirstName == "")
                {
                    NameTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Please enter Name");
                }
                else
                {
                    PasswordTxtBox.BackColor = Color.White;
                    Movies MoviesForm = new Movies();
                    MoviesForm.Show();
                }
    }

    private void Exit0btn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void PasswordTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult myAnswer;
        myAnswer = MessageBox.Show("Are you sure you want to clear the above?", "Confirmation", MessageBoxButtons.YesNo);
        if (myAnswer == DialogResult.Yes)
        {
            NameTxtBox.Clear();
            SurnameTxtBox.Clear();
            PasswordTxtBox.Clear();
        }
        else
        {
            MessageBox.Show("Please proceed to Confirm");
        }
    }
           
private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
