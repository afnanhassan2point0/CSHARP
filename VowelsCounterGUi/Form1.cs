namespace vowelscountergui;

public partial class Form1 : Form
{
    private TextBox txt1;
    private Label label;
    public Form1()
    {
        InitializeComponent();

        //! text box styling
        txt1 = new TextBox();
        txt1.Size = new Size(400, 100);
        txt1.Name = "txt1";
        txt1.Text = "Enter Sentence : ";
        txt1.Location = new Point(10, 10);

        //! label styling
        label = new Label();
        label.Location = new Point(10, 120);
        label.Name = "label";
        label.Size = new Size(200, 50);

        //! button styling
        Button btn = new Button();
        btn.Text = "Count Vowels";
        btn.Name = "btn";
        btn.Size = new Size(200, 50);
        btn.Location = new Point(220, 110);

        //! action
        btn.Click += (sender, e) =>
        {
            string text = txt1.Text.ToLower();
            int count = 0;
            foreach (char c in text)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            label.Text = "Vowels Count : " + count.ToString();
        };

        //! adding controls
        this.Controls.Add(txt1);
        this.Controls.Add(btn);
        this.Controls.Add(label);
    }
}
