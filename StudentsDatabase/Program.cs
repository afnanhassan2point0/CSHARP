namespace StudentsDatabase;

static class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Form sdb_main_form = new()
        {
            MinimumSize = new Size(400, 600),
            ForeColor = Color.White,
            BackColor = Color.DarkSlateGray,
        };

        //* Main page | Home Page
        //? Roll Number Fields
        Label rollNo_label = new()
        {
            Width = 150,
            Text = "Enter roll number",
            Location = new Point(20, 24),
        };
        TextBox rollNo_textBox = new()
        {
            Location = new Point(220, 24),
            TextAlign = HorizontalAlignment.Center,
        };

        //? Marks Fields
        Label marks_label = new()
        {
            Width = 150,
            Text = "Enter obtained marks",
            Location = new Point(20, rollNo_label.Bottom + 20),
        };
        TextBox marks_textBox = new()
        {
            Location = new Point(rollNo_textBox.Left, rollNo_textBox.Bottom + 20),
            TextAlign = HorizontalAlignment.Center,
        };

        //? Save Button
        Button save_button = new()
        {
            Width = 120,
            Height = 40,
            Text = "Save Data",
            ForeColor = Color.Black,
            BackColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(140, marks_textBox.Bottom + 100),
        };

        //? View Data Button
        Button viewData_button = new()
        {
            Width = 120,
            Height = 40,
            Text = "See Data",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(140, save_button.Bottom + 30),
        };

        //? Delete Data Button
        Button deleteData_button = new()
        {
            Width = 120,
            Height = 40,
            Text = "Delete Data",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(140, viewData_button.Bottom + 30),
        };

        //? Find Data Button
        Button findData_button = new()
        {
            Width = 120,
            Height = 40,
            Text = "Find Data",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(140, deleteData_button.Bottom + 30),
        };

        //! developer | coder | copyrights
        Label developer_label = new()
        {
            Width = 400,
            Text = "Developed by Muhammad Afnan Hassan #30",
            ForeColor = Color.SpringGreen,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, findData_button.Bottom + 50),
        };

        //* Action | installation
        sdb_main_form.Controls.Add(rollNo_label);
        sdb_main_form.Controls.Add(rollNo_textBox);

        sdb_main_form.Controls.Add(marks_label);
        sdb_main_form.Controls.Add(marks_textBox);

        sdb_main_form.Controls.Add(save_button);
        sdb_main_form.Controls.Add(findData_button);
        sdb_main_form.Controls.Add(viewData_button);
        sdb_main_form.Controls.Add(deleteData_button);

        sdb_main_form.Controls.Add(developer_label);
        Application.Run(sdb_main_form);
    }
}