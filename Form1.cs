using System.Text;
using System;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {


        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var name = textName.Text;
            string email = textEmail.Text;
            string contact = textContact.Text;
            MessageBox.Show("" + name + "\n" + email + "\n" + contact);
            /*
            String file = @"F:\Projects\C#\output.csv";
            String separator = ",";
            
            StringBuilder output = new StringBuilder();
            String[] headings = { "Name", "Email", "Contact" };
            output.AppendLine(string.Join(separator, headings));
            string newLine = string.Format("{0}, {1}, {2} ", name.ToString(), email.ToString(), contact.ToString());
            output.AppendLine(string.Join(separator, newLine));
            try
            {
                File.AppendAllText(file, output.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data could not be written to the CSV file.");
                return;
            }
            */
            string connectionString = @"Data Source=Omega\SQLEXPRESS;Initial Catalog=windowsFormTest;Integrated Security=True;Connect Timeout=30;MultiSubnetFailover=False";





            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    // SQL command to insert values into the table
                    command.CommandText = "INSERT INTO UserData (Name, Email, Contact) VALUES (@name, @email, @contact)";

                    // Set parameter values
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contact", contact);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Values inserted successfully:\n Name: "+name+"\n Email: "+email+"\n Contact: "+contact);
        }

    }
    
}