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
            catch
            {
                System.Console.WriteLine("Path not Valid");
            }
        }
        public static void Createfiles()
        {
            try
            {
                string pathname = "/Users/florian/DBun/FileTests/File.txt" ?? "";
                string FileName = "test.txt" ?? "";
                System.IO.File.Create(pathname , 2);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }




        }
    
    }
}

