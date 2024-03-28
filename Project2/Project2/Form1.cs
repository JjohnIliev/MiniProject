using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default values for ComboBoxes when the form is loaded
            Type.SelectedIndex = 0;
            Availability.SelectedIndex = 0;
            WiFiAvailable.SelectedIndex = 0;

        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=Project3; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM PCGamingClub WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (Type.SelectedItem != null)
                    conditions.Add("Type = @Type");

                if (Availability.SelectedItem != null)
                    conditions.Add("Availability = @Available");

                if (WiFiAvailable.SelectedItem != null)
                    conditions.Add("WiFiAvailable = @WiFiAvailable");

                if (idbox.SelectedItem != null)
                    conditions.Add("ID = @ID");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@Type", Type.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Available", Availability.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@WiFiAvailable", WiFiAvailable.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ID", idbox.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            Form2 john = new Form2();
            john.ShowDialog();


        }


    }
}