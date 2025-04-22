using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
namespace DBun
{
    public class Textfilemaker
    {
        public static void FileBrowser()
        {
            System.Console.WriteLine("This is the FileBrowser");
            System.Console.WriteLine("Please Enter a Command:");
            string mainpath = "/Users/florian/DBun/FileTests/";
            string name = Console.ReadLine() ?? "";
            //string Filename = Console.ReadLine() ?? "";
            bool isValid = name.Length != 0;
            string Filename;
            //bool OperatingSystem = OperatingSystem.IsMacOS() || OperatingSystem.IsLinux() || OperatingSystem.IsWindows();
            while (isValid == true)
            {
                
                try
                {
                    if (OperatingSystem.IsMacOS())
                    {
                        
                        System.Console.WriteLine("Use .. to open the FileBrowser");
                        System.Console.WriteLine("Use exit to get back to the main menu");
                        System.Console.WriteLine("Use search + Path to open the file");
                        System.Console.WriteLine("Use delete to delete the file + Path");
                        System.Console.WriteLine("Use create to create a file + Path");
                        if(name == "exit")
                        {
                            MainClass.run();
                            break;
                        }
                        else if (name == "search")
                        {
                            try
                            {
                                System.Console.WriteLine("Please Enter a Name for the File");
                                Filename = Console.ReadLine() ?? "";
                                string pathnameUInput = "/Users/florian/DBun/FileTests/" + Filename;
                                System.Diagnostics.Process.Start("open", pathnameUInput);
                                System.Console.WriteLine("File opened successfully.");
                                break;
                            }
                            catch (Exception e)
                            {
                                System.Console.WriteLine(e.Message);
                                break;
                            }
                        }
                        else if (name == "..")
                        {
                            System.Console.WriteLine("Open the FileBroser");
                            System.Diagnostics.Process.Start("open", mainpath);
                            break;
                        }
                        else if (name == "delete")
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
                        else if (name == "create")
                        {
                            System.Console.WriteLine("Please Enter a Name for the File");
                            string FileName = Console.ReadLine() ?? "";
                            string pathnameUInput = "/Users/florian/DBun/FileTests/" + FileName;
                            if (File.Exists(pathnameUInput))
                            {
                                System.Console.WriteLine("File already exists.");
                                break;
                            }
                            else
                            {
                                System.IO.File.Create(pathnameUInput, 1024, FileOptions.None);
                                System.Console.WriteLine("File created successfully.");
                                break;
                            }
                        }
                        else if (name == "help")
                        {
                            System.Console.WriteLine("Use .. to open the FileBrowser");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("error");
                            break;
                        }

                        
                       break;
                    }
                    
                    if (OperatingSystem.IsLinux())
                    {
                        System.Console.WriteLine("Use .. to open the FileBrowser");
                        if( name == "exit")
                        {
                            MainClass.run();
                            break;
                        }
                        else if (name == "..")
                        {
                            System.Console.WriteLine("Open the FileBroser...");                       
                            System.Diagnostics.Process.Start("xdg-open", mainpath);
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("error");
                            break;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("error");
                    }
                    if (OperatingSystem.IsWindows())
                    {
                        if( name == "exit")
                        {
                            MainClass.run();
                            break;
                        }
                        else if (name == "..")
                        {
                            System.Console.WriteLine("Open the FileBroser...");
                            System.Diagnostics.Process.Start("explorer.exe", mainpath);
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("error");
                            break;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("error");
                        break;
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                 
                    break;
                }     
            }
        }

    }
}

