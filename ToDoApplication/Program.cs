
using System.Data.SQLite;

// SQLite database file path
String dbPath = "Data Source=todo.db";

// Create or connect to the SQLite database
using (var connection = new SQLiteConnection(dbPath))
{
    connection.Open();

    // Create a table if it doesn’t already exist
    String createTableQuery = @"CREATE TABLE IF NOT EXISTS Tasks(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Task TEXT NOT NULL
                            );";
    using var command = new SQLiteCommand(createTableQuery, connection);
    command.ExecuteNonQuery();
}

// Initialize the WinForms application
ApplicationConfiguration.Initialize();

Form form = new();
form.Text = "To - Do App";
form.Width = 330;
form.Height = 250;

// Create controls
TextBox txtTask = new()
{
    Location = new System.Drawing.Point(12, 12),
    Width = 200
};
Button btnAddTask = new()
{
    Text = "Add Task",
    Location = new System.Drawing.Point(220, 10)
};
Button btnRemoveTask = new()
{
    Text = "Remove Task",
    Location = new System.Drawing.Point(220, 40)
};
ListBox listBoxTasks = new()
{
    Location = new System.Drawing.Point(12, 40),
    Width = 200,
    Height = 150
};

// Event to add a task
btnAddTask.Click += (sender, e) =>
{
    if (!string.IsNullOrWhiteSpace(txtTask.Text))
    {
        // Insert task into SQLite database
        using (var connection = new SQLiteConnection(dbPath))
        {
            connection.Open();
            String insertQuery = "INSERT INTO Tasks(Task) VALUES(@task)";
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@task", txtTask.Text);
                command.ExecuteNonQuery();
            }
        }

        // Add task to the ListBox
        listBoxTasks.Items.Add(txtTask.Text);
        txtTask.Clear();
    }
    else
    {
        MessageBox.Show("Please enter a task before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
};

// Event to remove selected task
btnRemoveTask.Click += (sender, e) =>
{
    if (listBoxTasks.SelectedIndex >= 0)
    {
        String selectedTask = listBoxTasks.SelectedItem.ToString();

        // Remove the task from the database
        using (var connection = new SQLiteConnection(dbPath))
        {
            connection.Open();
            String deleteQuery = "DELETE FROM Tasks WHERE Task = @task";
            using var command = new SQLiteCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@task", selectedTask);
            command.ExecuteNonQuery();
        }

        // Remove the task from the ListBox
        listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
    }
    else
    {
        MessageBox.Show("Please select a task to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
};

// Function to load tasks from the database on app startup
void LoadTasks()
{
    using var connection = new SQLiteConnection(dbPath);
    connection.Open();
    String selectQuery = "SELECT Task FROM Tasks";
    using var command = new SQLiteCommand(selectQuery, connection);
    using var reader = command.ExecuteReader();
    while (reader.Read())
    {
        listBoxTasks.Items.Add(reader["Task"].ToString());
    }
}

// Load tasks from the database when the app starts
LoadTasks();

// Add controls to the form
form.Controls.Add(txtTask);
form.Controls.Add(btnAddTask);
form.Controls.Add(btnRemoveTask);
form.Controls.Add(listBoxTasks);

// Run the application
Application.Run(form);


