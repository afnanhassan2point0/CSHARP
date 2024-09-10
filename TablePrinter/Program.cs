namespace TablePrinter;
static class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        // creating a window
        Form table_Printer_Window = new Form();
        Application.Run(new Form1());
    }
}