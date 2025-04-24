using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DBun
{
    public class Messages
    {        
        public static void Help()
        {
            System.Console.WriteLine("Commands:");
            System.Console.WriteLine("Browser - Open the file browser");
            System.Console.WriteLine("copy - Copy the first character of a string");
            System.Console.WriteLine("paste - Paste the copied character");
            System.Console.WriteLine("sound - Play a sound");
            System.Console.WriteLine("Countdown - Start a countdown");
            System.Console.WriteLine("DBTest - Test the database");
            System.Console.WriteLine("DatenBank - Show the database");
            System.Console.WriteLine("help - Show this help message");
            System.Console.WriteLine("exit - Exit the program");
            System.Console.WriteLine("clear - Clear the console");
        }
        public static void Browser()
        {
            System.Console.WriteLine("This is the file browser");
            System.Console.WriteLine("Please enter a command:");
            System.Console.WriteLine("Use .. to open the file browser");
            System.Console.WriteLine("Use exit to get back to the main menu");
            System.Console.WriteLine("Use search + Path to open the file");
            System.Console.WriteLine("Use delete to delete the file + Path");
            System.Console.WriteLine("Use create to create a file + Path");
            System.Console.WriteLine("Use help to see the commands");
        }
        public static void Calculator()
        {
            System.Console.WriteLine("This is the calculator");
            System.Console.WriteLine("Please enter a command:");
            System.Console.WriteLine("Use + to add two numbers");
            System.Console.WriteLine("Use - to subtract two numbers");
            System.Console.WriteLine("Use * to multiply two numbers");
            System.Console.WriteLine("Use / to divide two numbers");
            System.Console.WriteLine("Use exit to get back to the main menu");
            System.Console.WriteLine("Use help to see the commands");
        }

        public static void ExceptionCatcher()
        {
            // This method is used to catch exceptions and print the error message
            // You can customize the exception handling logic as needed
            // For example, you can log the exception to a file or display a user-friendly message
            // Here, we simply print the exception message to the console        
            try
            {
                MainClass.Program();  
                DebugloggerToFile();
            }
            catch 
            {
                ExceptionPrinter();                
            }
        }
        public static void ExceptionPrinter()
        {
            try
            {
                Exception ex = new(); 
                string Filename = "/Users/florian/DBun/DBun/FileTests/Exception.txt";
                // Create the file if it doesn't exist
                using (var fileStream = System.IO.File.Create(Filename))
                {
                    fileStream.Close();
                }
                // Write exception details to the file
                System.Console.WriteLine("An exception occurred. Please check the exception file for details.");
                System.IO.File.WriteAllText(Filename, $"Message: {ex.Message}\n");
                System.IO.File.AppendAllText(Filename, $"StackTrace: {ex.StackTrace}\n");
                System.IO.File.AppendAllText(Filename, $"Source: {ex.Source}\n");
                System.Console.WriteLine("Exception file created successfully.");
                System.Console.WriteLine("Exception message written to file successfully.");
            }
            catch (Exception ex)
            {
                string Filename = "/Users/florian/DBun/FileTests/Exception.txt";
                if (System.IO.File.Exists(Filename))
                {
                    // Append exception details to the file
                    System.IO.File.AppendAllText(Filename, $"Message: {ex.Message}\n");
                    System.IO.File.AppendAllText(Filename, $"StackTrace: {ex.StackTrace}\n");
                    System.IO.File.AppendAllText(Filename, $"Source: {ex.Source}\n");
                    System.Console.WriteLine("Exception message written to file successfully.");
                }
                else
                {
                    System.Console.WriteLine("Error: File not found.");
                }
            }
        }
        public static void DebugloggerToFile()
        {
            string Filename = "/Users/florian/DBun/FileTests/DebugLog.txt";
            // Create the file if it doesn't exist
            using (var fileStream = System.IO.File.Create(Filename))
            {
                fileStream.Close();
            }
            // Write debug message to the file
            System.IO.File.WriteAllText(Filename, Console.OutputEncoding.ToString());
            System.Console.WriteLine("Debug log file created successfully.");
        }
    }    
}