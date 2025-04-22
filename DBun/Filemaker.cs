using DBun;

public class Filemaker
{
        public static void Textfilemaketest()
        {
            System.Console.WriteLine("Please Enter a Path:");
            Console.Write("Please Enter a Path: -->" +  "@path");
            //string path = @"C:\Users\YourUsername\Documents\example.txt";
            try
            {
                string path = Console.ReadLine() ?? "";
                bool isValid = path.Length != 0;
                System.Console.WriteLine("Please Enter a Name for the File");
                string nameofFile = Console.ReadLine()?? " ";

                if (isValid == true)
                {
                    string[] lines = { "First line", "Second line", "Third line" }; 
        
                    System.IO.File.WriteAllLines(path, lines);
                    Console.WriteLine("Text file created successfully.");
                }
            }
            catch
            {

                Messages.ExceptionPrinter();
            }
        }
        public  static void Createfiles()
        {
            try
            {
                System.Console.WriteLine("Please Enter a Name for the File");
                string name = Console.ReadLine() ?? "";
                string pathname = "/Users/florian/DBun/FileTests/" + name;
                if (File.Exists(pathname + name ))
                {

                    System.Console.WriteLine("File already exists.");
                }
                else
                {
                    
                    System.IO.File.Create(pathname , 1024, FileOptions.None);
                    System.Console.WriteLine("File created successfully.");

                }
            }
            catch
            {
                Messages.ExceptionPrinter();
            }
        }
        public static void Deletefile()
        {
            try
            {
            System.Console.WriteLine("Please Enter a Name for the File");
            string FileName = Console.ReadLine() ?? "";
            string pathnameUInput = "/Users/florian/DBun/FileTests/" + FileName;
           
            if (File.Exists(pathnameUInput))
            {
                File.Delete(pathnameUInput);
                System.Console.WriteLine("File deleted successfully.");
            }
            else
            {
                System.Console.WriteLine("File not found.");
            }
            }
            catch
            {
                Messages.ExceptionPrinter();
            }
        }
}
         