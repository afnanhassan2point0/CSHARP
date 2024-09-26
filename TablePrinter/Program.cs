//* initializing the window
ApplicationConfiguration.Initialize();
Form tableContainer = new()
{
    Name = "Table Printer",
    Location = new(500, 500),
    MaximumSize = new(300, 720),
};

//? taking user inputs
Label userInputLabel = new()
{
    Text = "Enter a number : ",
    Size = new(130, 24),
    Location = new(10, 10),
};
TextBox userInputBox = new()
{
    Text = "2",
    TextAlign = HorizontalAlignment.Center,
    Size = new(80, 24),
    Location = new(150, 8),
    BackColor = Color.FromArgb(60, 60, 60),
    ForeColor = Color.FromArgb(212, 206, 11),
};
Button submitButton = new()
{
    Text = "Print Table",
    Size = new(110, 30),
    Location = new(135, 50),
    BackColor = Color.FromArgb(60, 60, 60),
    ForeColor = Color.FromArgb(255, 255, 255),
};

//? Action Goes here

//? loading the window
tableContainer.Controls.Add(userInputLabel);
tableContainer.Controls.Add(userInputBox);
tableContainer.Controls.Add(submitButton);
Application.Run(tableContainer);

//* user defined methods