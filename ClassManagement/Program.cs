//! initializing the main window
ApplicationConfiguration.Initialize();
Form classManagementForm = new()
{
    Size = new Size(480, 480),
};

//? taking user inputs
//* Student's Name
Label studentNameLabel = new()
{
    Text = "Enter name : ",
    Location = new(10, 10),
};
TextBox studentNameInput = new()
{
    Size = new(200, 24),
    Location = new(200, 8),
    TextAlign = HorizontalAlignment.Center,
    BackColor = Color.FromArgb(60, 60, 60),
    ForeColor = Color.FromArgb(212, 206, 11),
};
//* Student's Department Name
Label departmentLabel = new()
{
    Location = new(10, 40),
    Text = "Enter Department : ",
};
TextBox departmentInput = new()
{
    Size = new(200, 24),
    Location = new(200, 38),
    TextAlign = HorizontalAlignment.Center,
    BackColor = Color.FromArgb(60, 60, 60),
    ForeColor = Color.FromArgb(212, 206, 11),
};
//* Student's Degree
//* Student's Roll Number
//* Student's Marks / CGPA
Button submitButton = new()
{
    Text = "Print Table",
    Size = new(110, 30),
    Location = new(135, 360),
    BackColor = Color.FromArgb(60, 60, 60),
    ForeColor = Color.FromArgb(255, 255, 255),
};

//* Action Goes here


//* loading the window
classManagementForm.Controls.Add(studentNameLabel);
classManagementForm.Controls.Add(studentNameInput);
classManagementForm.Controls.Add(departmentLabel);
classManagementForm.Controls.Add(departmentInput);
classManagementForm.Controls.Add(submitButton);
Application.Run(classManagementForm);


//! user defined methods