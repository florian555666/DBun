using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace DBun
{

    internal class MainClass : DataBank
    {
        public static void Main(string[] args)
        {
            string EingabeString;            
            string EingabeString1;
            int[] i = new int[10];

            char[] resultBuffer = new char[1];
            bool level = true;
 
            Console.WriteLine("Use the command 'help' to see the commands.");
            while (level == true)
            {
            
                switch (EingabeString = Console.ReadLine() ?? "")
                {
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
                    Console.Clear();
                    break;
                    case "copy": 
                        Console.WriteLine("Write a string to copy the first character:");
                        System.Console.WriteLine("Write exit to exit the program.");
                        
                        // Check if EingabeString1 is not empty 
                        if (string.IsNullOrEmpty(EingabeString1 = Console.ReadLine() ?? ""))
                        {
                            
                                Console.WriteLine("EingabeString1 is empty. Please enter a string:");
                                // Read a new string from the console
                            
                                resultBuffer[0] = EingabeString1[0];
                                Console.WriteLine($"First character copied: {resultBuffer[0]}");
                        }
                        if (EingabeString1 == "exit")
                        {
                            goto case "help";
                        }

                        
                        // Check if EingabeString1 has at least one character
                        else if (EingabeString1.Length > 0)
                        {
                            // Copy the first character of EingabeString1 to resultBuffer
                            resultBuffer[0] = EingabeString1[0];
                            Console.WriteLine($"First character copied: {resultBuffer[0]}");
                        }
                        else
                        {
                            // Copy the first character of EingabeString1 to resultBuffer
                            Environment.Exit(0);
                        }
                        goto case "copy1"; 
                     // Paste the copied character
                    case "copy1":
                    
                        System.Console.WriteLine("Use the paste command to paste the copied character.");
                        break;
                    case "paste":
                    
                        Console.WriteLine("Try to paste the copied character...");
                        if (resultBuffer[0] == '\0')
                        {
                            Console.WriteLine("No character copied. Please use the copy command first.");
                        }
                        else
                        {
                            Console.WriteLine($"Pasted character: {resultBuffer[0]}");
                        }
                        
                    break;

                    default:
                    Console.WriteLine("Please use help");

                    
                    break;

                    
                }
            }
        }
    }
}
