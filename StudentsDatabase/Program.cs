using System.Data;
using System.Data.SQLite;

namespace StudentsDatabase;

static class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        // SQLite Connection Management
        SQLiteConnection sdb_sql_connection = new("Data Source=Students.db");
        sdb_sql_connection.Open();
        SQLiteCommand sdb_sql_command = sdb_sql_connection.CreateCommand();
        sdb_sql_command.CommandText = "CREATE TABLE IF NOT EXISTS RESULTS(RolNo integer primary key,MidMarks integer);";
        sdb_sql_command.ExecuteNonQuery();

        SQLiteDataAdapter sdb_sql_data_adapter = new("SELECT * FROM RESULTS", sdb_sql_connection);
        DataTable sdb_result_table = new();
        DataGridView sdb_gridView = new()
        {
            AutoSize = true,
            AllowUserToAddRows = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            ForeColor = Color.Black,
        };
        SQLiteCommandBuilder sql_cmd_builder = new(sdb_sql_data_adapter);

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
        Button update_button = new()
        {
            Width = 120,
            Height = 40,
            Text = "Update Data",
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
            Location = new Point(140, update_button.Bottom + 30),
        };

        //? Back to Home Button
        Button backHome_button = new()
        {
            Text = "Back to Home",
            AutoSize = true,
            Location = new Point(140, sdb_gridView.Bottom + 30),
        };

        //? Update Database record
        Button update_database_button = new()
        {
            Text = "Save Data",
            AutoSize = true,
            Location = new Point(150, backHome_button.Bottom + 30),
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

        //* Action
        save_button.Click += (s, e) =>
        {
            if (string.IsNullOrEmpty(rollNo_textBox.Text) || !rollNo_textBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter valid roll number (digits only).");
                return;
            }
            if (string.IsNullOrEmpty(marks_textBox.Text) || !marks_textBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter valid marks (integer only).");
                return;
            }

            sdb_sql_command.CommandText = $"INSERT INTO RESULTS(RolNo ,MidMarks) VALUES({rollNo_textBox.Text}, {marks_textBox.Text});";
            if (sdb_sql_command.ExecuteNonQuery() == 1)
            {
                rollNo_textBox.Text = "";
                marks_textBox.Text = "";
                MessageBox.Show("Data saved successfully!");
            }
            else
            {
                MessageBox.Show("error : Data could't be saved!\nTry again");
            }

        };

        viewData_button.Click += (s, e) =>
        {
            sdb_main_form.Controls.Remove(rollNo_label);
            sdb_main_form.Controls.Remove(rollNo_textBox);
            sdb_main_form.Controls.Remove(marks_label);
            sdb_main_form.Controls.Remove(marks_textBox);
            sdb_main_form.Controls.Remove(save_button);
            sdb_main_form.Controls.Remove(findData_button);
            sdb_main_form.Controls.Remove(viewData_button);
            sdb_main_form.Controls.Remove(update_button);

            sdb_result_table.Clear();
            sdb_sql_data_adapter.Fill(sdb_result_table);
            sdb_gridView.DataSource = sdb_result_table;
            sdb_main_form.Controls.Add(sdb_gridView);

            sdb_main_form.Controls.Add(backHome_button);
        };

        update_button.Click += (s, e) =>
        {
            sdb_main_form.Controls.Remove(rollNo_label);
            sdb_main_form.Controls.Remove(rollNo_textBox);
            sdb_main_form.Controls.Remove(marks_label);
            sdb_main_form.Controls.Remove(marks_textBox);
            sdb_main_form.Controls.Remove(save_button);
            sdb_main_form.Controls.Remove(findData_button);
            sdb_main_form.Controls.Remove(viewData_button);
            sdb_main_form.Controls.Remove(update_button);

            sdb_result_table.Clear();
            sdb_sql_data_adapter.Fill(sdb_result_table);
            sdb_gridView.DataSource = sdb_result_table;
            sdb_main_form.Controls.Add(sdb_gridView);

            sdb_main_form.Controls.Add(backHome_button);
            sdb_main_form.Controls.Add(update_database_button);
        };

        update_database_button.Click += (s, e) =>
        {
            sdb_sql_data_adapter.Update(sdb_result_table);
            MessageBox.Show("Data updated successfully");
        };

        backHome_button.Click += (s, e) =>
        {
            sdb_main_form.Controls.Remove(sdb_gridView);
            sdb_main_form.Controls.Remove(backHome_button);
            sdb_main_form.Controls.Remove(update_database_button);

            sdb_main_form.Controls.Add(rollNo_label);
            sdb_main_form.Controls.Add(rollNo_textBox);
            sdb_main_form.Controls.Add(marks_label);
            sdb_main_form.Controls.Add(marks_textBox);
            sdb_main_form.Controls.Add(save_button);
            sdb_main_form.Controls.Add(findData_button);
            sdb_main_form.Controls.Add(viewData_button);
            sdb_main_form.Controls.Add(update_button);
        };

        //* Installation
        sdb_main_form.Controls.Add(rollNo_label);
        sdb_main_form.Controls.Add(rollNo_textBox);

        sdb_main_form.Controls.Add(marks_label);
        sdb_main_form.Controls.Add(marks_textBox);

        sdb_main_form.Controls.Add(save_button);
        sdb_main_form.Controls.Add(findData_button);
        sdb_main_form.Controls.Add(viewData_button);
        sdb_main_form.Controls.Add(update_button);

        sdb_main_form.Controls.Add(developer_label);
        Application.Run(sdb_main_form);
    }
}