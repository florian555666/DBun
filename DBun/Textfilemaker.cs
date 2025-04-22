using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
namespace DBun
{
    public class Textfilemaker
    {
        public static void Textfilemake()
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
            catch(Exception e)
            {

                System.Console.WriteLine(e.Message);
            }
        }
        public  static void Createfiles()
        {
            try
            {
                string pathname = "/Users/florian/DBun/FileTests/" ?? "";
                if (File.Exists(pathname))
                {

                    System.Console.WriteLine("File already exists.");
                }
                else
                {
                    System.Console.WriteLine("Please Enter a Name for the File");
                    string FileName = Console.ReadLine() ?? "";
                    string pathnameUInput = pathname + FileName;
                    System.IO.File.Create(pathnameUInput , 1024, FileOptions.None);
                    System.Console.WriteLine("File created successfully.");

                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public static void Deletefile()
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
        public static void FileBrowser()
        {
            System.Console.WriteLine("Please Enter a Name for the File");
            string FileName = Console.ReadLine() ?? "";
            string pathnameUInput = "/Users/florian/DBun/FileTests/" + FileName;
            bool isValid = pathnameUInput.Length != 0;
            while (isValid == true)
            {
                System.Console.WriteLine("Please Enter a Name for the File");
                string FileName2 = Console.ReadLine() ?? "";
                pathnameUInput = "/Users/florian/DBun/FileTests/" + FileName2;
                isValid = pathnameUInput.Length != 0;
            }
            if (OperatingSystem.IsWindows())
            {
                System.Diagnostics.Process.Start("explorer.exe", pathnameUInput);
            }
            else if (OperatingSystem.IsLinux())
            {
                System.Diagnostics.Process.Start("xdg-open", pathnameUInput);
            }
            else if (OperatingSystem.IsMacOS())
            {
                System.Diagnostics.Process.Start("open", pathnameUInput);
            }
            else
            {
            
                System.Diagnostics.Process.Start("explorer.exe", pathnameUInput);
            }
            

        }
    }
}

