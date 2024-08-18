namespace VowelsCounterGUi;

public partial class VowelsCounter : Form
{
    //* class level fields declaration
    private TextBox txt1;
    private Label label1;
    
    public VowelsCounter()
    {
        InitializeComponent();

        //! initializing the txt1 field
        txt1 = new TextBox();
        txt1.Name = "txt1";
        txt1.Text = "Enter sentence";
        txt1.Size = new Size(200, 100);
        txt1.Location = new Point(10,10);

        //! initializing the label1 field
        label1 = new Label();
        label1.Name = "label1";
        label1.Size = new Size(200, 50);
        label1.Location = new Point(10,120);

        //! initializing the btn1
        Button btn1 = new Button();
        btn1.Text = "Count Vowels";
        btn1.Name = "btn1";
        btn1.Size = new Size(100, 50);
        btn1.Location = new Point(220, 10);

        //! action
        btn1.Click += (sender, e) =>{
            //? counting vowels
            string text = txt1.Text.ToLower();
            int vowCount = 0;
            foreach( char ch in text){
                if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch 'u'){
                    vowCount++;
                }
            };

            //? updating label1
            label1.Text = "Vowels : " + vowCount.ToString();
        };

        //* adding controls
        this.Controls.Add(txt1);
        this.Controls.Add(btn1);
        this.Controls.Add(label1);
    }
}