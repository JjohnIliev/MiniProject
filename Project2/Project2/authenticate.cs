using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2
{
    public class authenticate
    {
        public class User
        {
            public string Username { get; set; } // User's username property

        }


        public class DatabaseManager
        {
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

           
            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=UsernameLogin; Integrated Security=True;"))
                {
                    sqlCon.Open(); 

                    string Query = "SELECT COUNT(1) FROM UserCredentials WHERE Username=@Username AND Password=@Password";

                    SqlCommand cmd = new SqlCommand(Query, sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", username); // pass username parameter
                    cmd.Parameters.AddWithValue("@Password", password); // pass password parameter

                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // Execute query and get the count

                    if (count == 1)
                    {
                        // Return a User object with the retrieved information
                        return new User { Username = username };
                    }
                    return null; // Return null if no user is found with the specified username and password
                }
            }
        }
    }
}