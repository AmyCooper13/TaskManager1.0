using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager1._0
{
    public partial class AddTask : Form
    {
        private string connectionString = "Data Source=MSI\\SQLEXPRESS04;Initial Catalog=TaskManager;Integrated Security=True;TrustServerCertificate=True";

        public event Action TaskAdded;

        public AddTask()
        {
            InitializeComponent();
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            comboPriority.Items.Add("Low");
            comboPriority.Items.Add("Medium");
            comboPriority.Items.Add("High");

            comboPriority.SelectedIndex = 0;
        }





        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskDescription = txtTaskDescription.Text;
            DateTime dueDate = dateTimePicker1.Value;
            string priorityLevel = comboPriority.SelectedItem.ToString();

            SaveTask(taskDescription, dueDate, priorityLevel);
            TaskAdded?.Invoke();

            txtTaskDescription.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboPriority.SelectedIndex = 0;
        }





        private void SaveTask(string description, DateTime dueDate, string priorityLevel)
        {
            string query = "INSERT INTO Tasks (TaskDescription, Status, DueDate, PriorityLevel) " +
                           "VALUES (@description, @status,  @dueDate, @priorityLevel)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@status", "Incomplete");
                    command.Parameters.AddWithValue("@dueDate", dueDate);
                    command.Parameters.AddWithValue("@priorityLevel", priorityLevel);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error adding task.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        
    }

}
