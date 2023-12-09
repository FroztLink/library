using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace elibrary_system
{
    public partial class BELMSloginform : Form
    {
        public BELMSloginform()
        {
            InitializeComponent();
        }

        private void BELMSloginform_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=belms_db;Uid=root;Pwd='';");
                connection.Open();

                string username = txtID.Text;
                string password = txtPassword.Text;

                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE ID='"+username+"'", connection);
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM users WHERE ID='"+username + "' AND password='"+password+"'", connection);

                var result = command.ExecuteScalar();
                var result2 = command2.ExecuteScalar();



                if(result != null)
                {
                    if(result2 != null)
                    {
                        MySqlCommand accesscommand = new MySqlCommand("SELECT access_m FROM users WHERE ID='" + username + "' AND password='" + password + "'", connection);
                        object obj = accesscommand.ExecuteScalar();
                        int access = (int)obj;
                        string type;
                        switch (access)
                        {
                            case 0:
                                type = "Administrator";
                                //Redirect here to admin window
                                break;
                            case 1:
                                type = "Faculty";
                                //Redirect here to admin window
                                break;
                            case 2:
                                type = "Student";
                                //Redirect here to admin window
                                break;
                            default:
                                type = "NULL"; break;
                                //Error Handler
                        }
                        
                        MessageBox.Show("Login Success! Welcome " + type + "!");
                    }
                    else
                    {
                        MessageBox.Show("ID or Password Incorrect");
                    }
                        // Process each row
                    
                }
                else
                {
                    MessageBox.Show("Tagasan ka boi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }
    }
}
