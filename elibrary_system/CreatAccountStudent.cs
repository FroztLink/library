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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace elibrary_system
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            comboGradelvl.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) ||
            string.IsNullOrEmpty(txtFname.Text) ||
            string.IsNullOrEmpty(txtMname.Text) ||
            string.IsNullOrEmpty(txtLname.Text) ||
            string.IsNullOrEmpty(txtPassword.Text) ||
            string.IsNullOrEmpty(comboGradelvl.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // All fields are filled, proceed with account creation
                AddToDatabase();
            }
        }

        private void AddToDatabase()
        {
            string connectionString = "Server=localhost;Database=belms_db;Uid=root;Pwd='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE ID = @ID";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@ID", txtID.Text);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("An account already exists for this ID number.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = "INSERT INTO users (f_name, m_name, l_name, ID, password, access_m) " +
                               "VALUES (@f_name, @m_name, @l_name, @ID, @password, '2')";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@f_name", txtFname.Text);
                    command.Parameters.AddWithValue("@m_name", txtMname.Text);
                    command.Parameters.AddWithValue("@l_name", txtLname.Text);
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
