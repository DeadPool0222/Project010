using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_M_House_Rental
{
    public partial class Login : Form
    {
        
        private string connectionString = "Data Source=DESKTOP-E0AQVDS\\SQL;Initial Catalog=Login;Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Text1.Text.Trim();
            string passwordText = Text2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwordText))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            
            if (!int.TryParse(passwordText, out int password))
            {
                MessageBox.Show("Password must be an integer.");
                return;
            }

            string query = "SELECT id, username, role FROM accounts WHERE username = @username AND password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                       
                        string role = reader["role"].ToString();
                        int userId = (int)reader["id"];
                        MessageBox.Show($"Welcome, {username}! Your user ID is {userId} and your Role is {role}.");
                        
                        Tenants form = new Tenants();
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD! PLEASE TRY AGAIN.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();

                  
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            Text2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Test database connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("CONNECTION ESTABLISHED");
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Can't open connection! Details: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
