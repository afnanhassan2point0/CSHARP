// File Manipulation
// Creating a file and writing some data on it  :: 01
#region 
// This method will always overwrite the file if existed
FileInfo myFile = new("d://myFile.txt"); // creates an object having file information for next steps

FileStream myFileStream = myFile.Open(FileMode.OpenOrCreate, FileAccess.Write); // creates/opens the file for writing purpose

StreamWriter writeInFile = new(myFileStream); // an object that will help in writing anything to target file

for (int i = 0; i < 5; i++) // to write 5 lines in file
{
    writeInFile.WriteLine("Hi I am Muhammad Afnan Hassan, an App Developer on MERN!!");
}

writeInFile.Close(); // stream-writer must be closed at the end of desired operations ~

Console.WriteLine($"\nHi, The file '{myFile}' created successfully\n");
#endregion


// Appending data on File  :: 02
#region 
// This method will always Add/Append the file if existed
// step 1 : creating StreamWriter object, that is already done, so can be reused here in this case
writeInFile = File.AppendText("d://myFile.txt"); // directly pass file.txt address
// step 2 : write something that is desired to append in the existing record
writeInFile.WriteLine("This line was appended by using StreamWriter class & File.AppendText method");
writeInFile.Close(); // stream-writer must be closed at the end of desired operations ~
#endregion


// Creating a file :: 02
// for creating and writing a file
#region 
string filePath = "d://myDemo.txt"; // to store file path for operations
File.Create(filePath); // creates the file in target address
if (File.Exists(filePath)) // to check if the file exists or not
{
    Console.WriteLine($"file '{filePath}' created\n");
    File.WriteAllText(filePath, "Hello I am nowhere"); // for writing a single line
    string[] myLines =
    [
        "\nThis is line no 1",
        "This is another line of no2",
        "And there we go again"
    ]; // for writing the multiple lines
    File.AppendAllLines(filePath, myLines); // appends data to the file, if existed
}
else
    Console.WriteLine($"unable to create file '{filePath}'\n");

#endregion


// Creating a folder or Directory :: 01
#region 
// only to create a folder and directory
Directory.CreateDirectory("d://Csharp//demoFolder"); // creates folders in target directory
if (Directory.Exists("d://Csharp//demoFolder"))
    Console.WriteLine("folder created\n");
else
    Console.WriteLine("folder not created\n");

#endregion

// Get List of files in folder :: 01
#region 
string pathGiven = "D://"; // folder or directory path containing some files
if (Directory.Exists(pathGiven))
{
    string[] filesList = Directory.GetFiles(pathGiven); // assigns all files info to the string array filesList
    foreach (var file in filesList)
    {
        Console.WriteLine(file); // prints all files of fileList
    }
}
else Console.WriteLine("error : directory doesn't exit ");
#endregion

// Reading a file and Printing data to console  :: 01
#region 
// 1st step is FileInfo object creation, that is already done in upper steps
// 2nd step is FileStream object creation, with FileAccess = Read
FileStream readFromFile = myFile.Open(FileMode.Open, FileAccess.Read);

// 3rd step is StreamReader :
StreamReader streamMyData = new(readFromFile);

String myFileData = streamMyData.ReadToEnd(); // this method stores all file data in a variable
Console.WriteLine(myFileData);

readFromFile.Close(); // stream-reader must be closed at the end of desired operations ~
#endregion

// Reading file :: 02
#region 
// step 1 : create string variable to store path, that is already created so reusing it
filePath = "d://myDemo.txt";
// step 2 : checks if file exists
if (File.Exists(filePath))
{
    string[] myLines = File.ReadAllLines(filePath); // string array for storing multiple lines
    foreach (var line in myLines) // looping through all elements containing individual lines
    {
        Console.WriteLine(line);
    }
}
else Console.WriteLine("error : file not found");
#endregion