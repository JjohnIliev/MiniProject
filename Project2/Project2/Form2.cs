using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project2.authenticate;


namespace Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private User authenticatedUser;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=Project3; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT Availability FROM PCGamingClub WHERE ID = @ID";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@ID", id.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    // Room is available, proceed with booking
                    string insertQuery = "INSERT INTO Contacts VALUES (@ID, @Naame, @PhoneNumber, @Email)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@ID", id.Text);
                    insertCmd.Parameters.AddWithValue("@Naame", guestName.Text);
                    insertCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                    insertCmd.Parameters.AddWithValue("@Email", email.Text);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE PCGamingClub SET Availability = 'Out of Service' WHERE ID = @ID";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@ID", id.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, this is not available for booking.");
                }
            }
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (phoneNumber.Text.Length <= 9)
            {
                MessageBox.Show("The phone number should be at least 10 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumber.Focus();
                e.Cancel = true;
            }
        }
    }
}