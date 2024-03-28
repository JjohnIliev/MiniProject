using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project2.authenticate;
namespace Project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            // Connecting to the database


            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(username, password);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Form1 welcome = new Form1();
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }

        }
    }
}
