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
/// Try to run it with an external Console
/// For Sounds
///summary
namespace DBun
{
    public class MainClass : DataBank 
    {
        public static void DebuggerRunner()
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
            Messages.ExceptionCatcher();
            Messages.DebugloggerToFile();
        }
        public static void Program()
        {
            string EingabeString;            
            char[] resultBuffer = new char[1];
            Console.WriteLine("Use the command 'help' to see the commands.");
            while (true)
            {
                System.Console.WriteLine("Use . to get back to the main menu.");
                switch (EingabeString = Console.ReadLine() ?? "")
                {
                    case "Browser":
                    FileBrowser.OpenFileBrowser();
                    break;
                    case "DBTest":
                    System.Console.WriteLine("DBTest" + $"{Kategorie} {Name} {Preis}");
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
                    Sound.Run();
                    break;
                    case "countdown":
                    Countdown.Start();
                    break;
                    case "Calculator":
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
