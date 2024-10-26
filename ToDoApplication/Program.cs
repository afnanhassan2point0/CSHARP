
//* Application Initialization
using System.Data.SQLite;

ApplicationConfiguration.Initialize();

//!     User - Interface

//* creating form

Form form = new()
{
    Text = "Your To-Do Tasks",
    Width = 400, // 350
    Height = 540, // 250
    ForeColor = Color.White,
    BackColor = Color.FromArgb(85, 102, 119),
};

//* creating controls

TextBox textTask = new()
{
    Width = 225,
    Height = 32,
    Location = new Point(12, 12),
    ForeColor = Color.White,
    BackColor = Color.FromArgb(88, 50, 204),
    BorderStyle = BorderStyle.None,
    PlaceholderText = "Type here...",
    TextAlign = HorizontalAlignment.Center,
};

ListBox listBoxTasks = new()
{
    Width = 225,
    Height = 400,
    Location = new Point(12, 50),
    ForeColor = Color.White,
    BackColor = Color.FromArgb(132, 92, 254),
    ItemHeight = 20,
    // Items.Padding = new Padding(10, 0, 10, 0),
};

Button btnAddTask = new()
{
    AutoSize = true,
    Text = "Add Task",
    Location = new Point(260, 10),
    UseVisualStyleBackColor = true,
    ForeColor = Color.White,
    BackColor = Color.FromArgb(216, 0, 50),
    Padding = new Padding(5, 1, 5, 1),
};

Button btnRemoveTask = new()
{
    AutoSize = true,
    Text = "Delete",
    Location = new Point(265, 60),
    UseVisualStyleBackColor = true,
    ForeColor = Color.White,
    BackColor = Color.FromArgb(216, 0, 50),
    Padding = new Padding(5, 1, 5, 1),
};


//!     Backend Database Code
//* creating Database
SQLiteConnection liteConnection = new("Data Source = todoList.db");
liteConnection.Open();
SQLiteCommand liteCommand = liteConnection.CreateCommand();
liteCommand.CommandText = "CREATE TABLE IF NOT EXISTS UserTasks(TaskText text);";
liteCommand.ExecuteNonQuery();

//!     A C T I O N

//* Adding a Task

btnAddTask.Click += (s, e) =>
{
    if (!string.IsNullOrEmpty(textTask.Text))
    {
        listBoxTasks.Items.Add(textTask.Text);
        liteCommand.CommandText = $"INSERT INTO UserTasks(TaskText) VALUES ({textTask.Text})";
        if (liteCommand.ExecuteNonQuery() != 1)
        {
            MessageBox.Show("Error: encountered an error while adding this task to database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        textTask.Clear();
    }
    else
    {
        MessageBox.Show("Please enter a task before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
};

//* Removing a Task

btnRemoveTask.Click += (s, e) =>
{
    if (listBoxTasks.SelectedIndex >= 0)
    {
        listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
    }
    else
    {
        MessageBox.Show("Please select a task to be removed.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
};


//!     C O N T R O L L S

form.Controls.Add(textTask);
form.Controls.Add(btnAddTask);
form.Controls.Add(btnRemoveTask);
form.Controls.Add(listBoxTasks);


//* Application Running
Application.Run(form);

