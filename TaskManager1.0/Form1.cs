using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TaskManager1._0
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=MSI\\SQLEXPRESS04;Initial Catalog=TaskManager;Integrated Security=True;TrustServerCertificate=True";
        private ErrorProvider errorProvider = new ErrorProvider();



        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
            LoadAllTasks();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);

        }

        
        private void LoadAllTasks(string searchTerm = "")
        {
            string query = "SELECT TaskId, PriorityLevel, TaskDescription, Status, DueDate, CompletionDate FROM Tasks";
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE TaskDescription LIKE @searchTerm OR TaskId LIKE @searchTerm";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        row["Status"] = row["Status"].ToString().Equals("Complete", StringComparison.OrdinalIgnoreCase);
                    }

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("An error occurred while loading tasks.", ex);
                }
            }
        }
        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show($"{message} \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }







        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadAllTasks(searchTerm);
        }
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadAllTasks();
        }




        





        




        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTask addTaskForm = new AddTask();
            addTaskForm.TaskAdded += () => LoadAllTasks();
            addTaskForm.Show();
        }





        private void PopulateComboBoxes()
        {
            comboStatus.Items.Clear();
            comboStatus.Items.Add("Incomplete");
            comboStatus.Items.Add("Complete");

            comboStatus.SelectedItem = "";

            ComboUpdatePriority.Items.Clear();
            ComboUpdatePriority.Items.Add("Low");
            ComboUpdatePriority.Items.Add("Medium");
            ComboUpdatePriority.Items.Add("High");

            ComboUpdatePriority.SelectedItem = "";
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a task to update.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);

                string taskDescription = txtTaskDescriptionUpdate.Text;
                string status = comboStatus.SelectedItem.ToString();
                string priority = ComboUpdatePriority.SelectedItem.ToString();
                DateTime dueDate = DTPDueDate.Value;
                DateTime? completionDate = DTPCompletionDate.Value != DateTime.Now ? (DateTime?)DTPCompletionDate.Value : null;

                UpdateTask(taskId, taskDescription, status, priority, dueDate, completionDate);
            
        }
        private void UpdateTask(int taskId, string taskDescription, string status, string priority, DateTime dueDate, DateTime? completionDate)
        {
            string query = "UPDATE Tasks SET TaskDescription = @taskDescription, Status = @status, " +
                           "PriorityLevel = @priority, DueDate = @dueDate, CompletionDate = @completionDate " +
                           "WHERE TaskId = @taskId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@taskDescription", taskDescription);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@priority", priority);
                    command.Parameters.AddWithValue("@dueDate", dueDate);
                    command.Parameters.AddWithValue("@completionDate", (object)completionDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@taskId", taskId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task updated successfully!");
                        LoadAllTasks();
                    }
                    else
                    {
                        MessageBox.Show("Error updating task.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("An error occurred while updating the task.", ex);
                }
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);

            string deleteQuery = "DELETE FROM Tasks WHERE TaskId = @TaskId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Task deleted successfully!" : "Failed to delete task.");
                    LoadAllTasks();
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("An error occurred while deleting the task.", ex);
                }
            }
        }





        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string taskDescription = selectedRow.Cells["TaskDescription"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string priority = selectedRow.Cells["PriorityLevel"].Value.ToString();
                DateTime dueDate = selectedRow.Cells["DueDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);
                DateTime? completionDate = selectedRow.Cells["CompletionDate"].Value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(selectedRow.Cells["CompletionDate"].Value);


                txtTaskDescriptionUpdate.Text = taskDescription;
                comboStatus.SelectedItem = status;
                ComboUpdatePriority.SelectedItem = priority;
                DTPDueDate.Value = dueDate;
                DTPCompletionDate.Value = completionDate ?? DateTime.Now;
            }
        }

    }
}
