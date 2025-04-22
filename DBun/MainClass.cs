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
                // Optionally, launch a debugger
                Debugger.Launch(); // This will prompt to attach a debugger if none is attached
            }

            
        }

        public static void Main(string[] args)
        {
            //hello();
            //run();
            Messages.ExceptionCatcher();
        }
        public static void Run()
        {
            string EingabeString;            
            char[] resultBuffer = new char[1];
            bool level = true;
            Console.WriteLine("Use the command 'help' to see the commands.");
            while (level == true)
            {
                System.Console.WriteLine("Use . to get back to the main menu.");
                switch (EingabeString = Console.ReadLine() ?? "")
                {
                    case "create":
                    Filemaker.Createfiles();
                    break;
                    case "delete":
                    Filemaker.Deletefile();
                    break;
                    case "Browser":
                    Textfilemaker.FileBrowser();
                    break;
                    case "DBTest":
                    DataBank.DB(Kategorie);
                    break;
                    case "help":
                    Messages.Help();
                    break;
                    case "exit":
                    Environment.Exit(0);
                    break;
                    case "clear":
                    System.Console.Clear();
                    break;
                    case "copy": 
                    CopyMMethod.Copy();
                    break;
                    case "paste":
                    CopyMMethod.Paste();
                    break;
                    case "sound":
                    Sounds.Sound();
                    break;
                    case "countdown":
                    Countdown.Start();
                    break;
                    case "calc":
                    Calculator.Evaluate();
                    break;
                    case ".":      
                    goto case "help"; 
                    default:
                    Console.WriteLine("Please use help");
                    break;
                }
            }
        }

    }
}
