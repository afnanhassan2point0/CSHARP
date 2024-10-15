
//* Application Initialization
ApplicationConfiguration.Initialize();

//!     User - Interface

//* creating form

Form form = new()
{
    Text = "To-Do App",
    Width = 350,
    Height = 250,
    BackColor = Color.DarkOrange,
};

//* creating controls

TextBox textTask = new()
{
    Width = 200,
    Location = new Point(12, 12),
};

Button btnAddTask = new()
{
    AutoSize = true,
    Text = "Add Task",
    Location = new Point(220, 10),
    UseVisualStyleBackColor = true,
};

Button btnRemoveTask = new()
{
    AutoSize = true,
    Text = "Remove Task",
    Location = new Point(220, 40),
    UseVisualStyleBackColor = true,
};

ListBox listBoxTasks = new()
{
    Width = 200,
    Height = 150,
    Location = new Point(12, 40),
};

//!     A C T I O N

//* Adding a Task

btnAddTask.Click += (s, e) =>
{
    if (!string.IsNullOrEmpty(textTask.Text))
    {
        listBoxTasks.Items.Add(textTask.Text);
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

