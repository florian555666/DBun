using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
///summary
///MainClass:
///Set UserInput
/// Add some UserCommands:
/// + makefile
/// + DBTest
/// + DatenBank
/// + help
/// + exit
/// + clear
/// + copy
/// + paste
///Create a DataBank with items
///
///summary
namespace DBun
{

    public class MainClass : DataBank 
    {
        public static void hello()
        {
            // Check if a debugger is attached
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Debugger is attached.");
            }
            else
            {
                Console.WriteLine("No debugger is attached.");
            }

            // Optionally, launch a debugger
            Debugger.Launch(); // This will prompt to attach a debugger if none is attached
            
        }

        public static void Main(string[] args)
        {
            MainClass.run();

        }
        public static void run(){
            string EingabeString;            
            char[] resultBuffer = new char[1];
            bool level = true;
            Console.WriteLine("Use the command 'help' to see the commands.");
            while (level == true)
            {
                System.Console.WriteLine("Use . to get back to the main menu.");
                switch (EingabeString = Console.ReadLine() ?? "")
                {
                    case "mk":
                    Textfilemaker.Createfiles();
                    break;
                    case "makefile":
                    Textfilemaker.Textfilemake();
                    break;
                    case "DBTest":
                    DataBank.DB(Kategorie);
                    break;
                    case "DatenBank":
                    Console.WriteLine(Kategorie);
                    break;
                    case "help":
                    Console.WriteLine("***Commandslist***");
                    Console.WriteLine("DatenBank");
                    Console.WriteLine("exit");
                    Console.WriteLine("DBTest");
                    Console.WriteLine("help");
                    Console.WriteLine("copy");
                    Console.WriteLine("paste");
                    Console.WriteLine("******************");
                    break;
                    case "exit":
                    Environment.Exit(0);
                    break;
                    case "clear":
                    System.Console.Clear();
                    break;
                    case "copy": 
                    CopyMMethod.Copy( resultBuffer);
                    break;
                    case "paste":
                    CopyMMethod.Paste(ref resultBuffer);
                    break;
                    case "WIP":
                    WorkInProgress();
                    break;
                    case "sound":
                    Countdown.Sound();
                    break;
                    default:
                    Console.WriteLine("Please use help");
                    break;
                    case "test":
                    Countdown.start();
                    break;
                    case "delete":
                    Textfilemaker.Deletefile();
                    break;
                    case "filebrowser":
                    Textfilemaker.FileBrowser();
                    break;
                    case ".":      
                    goto case "help";  
                }
            }
        }
        public static void WorkInProgress()
        {
            //Calculator.Evaluate();
            for(int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Hello World");     
            }
            while (true)
            {  
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                    Console.WriteLine("Hello World");
                    System.Threading.Thread.Sleep(1000); // Sleep for 1 second
                    break;
                }
            }
        }
    }
}
