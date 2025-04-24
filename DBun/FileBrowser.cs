using System.IO.Enumeration;
using System.Reflection.Metadata;

namespace DBun
{
    public class FileBrowser
    {
        public static void OpenFileBrowser()
        {
            Messages.Browser();
            string currentPath = Directory.GetCurrentDirectory() + "FileTests/";
            string PlayerInput = Console.ReadLine() ?? "";
            switch (PlayerInput)
            {
                case "..":
                    System.Console.WriteLine("Open the FileBroser");
                    string mainpath = "/Users/";
                    System.Diagnostics.Process.Start("open", mainpath);
                    break;
                case "search":
                    System.Console.WriteLine("Please Enter a Name for the File");
                    string Filename = Console.ReadLine() ?? "";
                    string pathnameUInput = currentPath + Filename;
                    OpenFile(pathnameUInput);
                    break;
                case "delete":
                    System.Console.WriteLine("Please Enter a Name for the File to delete");
                    string FilenameToDelete = Console.ReadLine() ?? "";
                    string pathnameToDelete = currentPath + FilenameToDelete;
                    DeleteFile(pathnameToDelete);
                    break;
                case "create":
                    System.Console.WriteLine("Please Enter a Name for the File to create");
                    string FilenameToCreate = Console.ReadLine() ?? "";
                    string pathnameToCreate = currentPath + FilenameToCreate;
                    CreateFile(pathnameToCreate);
                    break;
                case "exit":
                    MainClass.Program();
                    break;
                case "createfolder":
                    System.Console.WriteLine("Please Enter a Name for the Folder to create");
                    string FoldernameToCreate = Console.ReadLine() ?? "";
                    string folderpathToCreate = currentPath + FoldernameToCreate;
                    CreateFolder(folderpathToCreate);
                    break;
                case "deletefolder":
                    System.Console.WriteLine("Please Enter a Name for the Folder to delete");
                    string FoldernameToDelete = Console.ReadLine() ?? "";
                    string folderpathToDelete = currentPath + FoldernameToDelete;
                    DeleteFolder(folderpathToDelete);
                    break;
                case "openfolder":
                    System.Console.WriteLine("Please Enter a Name for the Folder to open");
                    string FoldernameToOpen = Console.ReadLine() ?? "";
                    string folderpathToOpen = currentPath + FoldernameToOpen;
                    OpenFolder(folderpathToOpen);
                    break;
                default:
                    System.Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        }
        public static void OpenFile(string filePath)
        {
            System.Diagnostics.Process.Start("open", filePath);
            System.Console.WriteLine("File opened successfully.");
        }
        public static void DeleteFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
                System.Console.WriteLine("File deleted successfully.");
            }
            else
            {
                System.Console.WriteLine("File not found.");
            }
        }
        public static void CreateFile(string filePath)
        {
            string directoryPath = System.IO.Path.GetDirectoryName(filePath) ?? string.Empty;
            if (!System.IO.Directory.Exists(directoryPath))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
            }

            if (System.IO.File.Exists(filePath))
            {
                System.Console.WriteLine("File already exists.");
                return;
            }
            using (var fileStream = System.IO.File.Create(filePath))
            {
                fileStream.Close();
            }
            System.Console.WriteLine("File created successfully.");
        }
        public static void OpenFolder(string folderPath)
        {
            System.Diagnostics.Process.Start("open", folderPath);
            System.Console.WriteLine("Folder opened successfully.");
        }
        public static void DeleteFolder(string folderPath)
        {
            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
                System.Console.WriteLine("Folder deleted successfully.");
            }
            else
            {
                System.Console.WriteLine("Folder not found.");
            }
        }
        public static void CreateFolder(string folderPath)
        {
            if (System.IO.Directory.Exists(folderPath))
            {
                System.Console.WriteLine("Folder already exists.");
                return;
            }
            System.IO.Directory.CreateDirectory(folderPath);
            System.Console.WriteLine("Folder created successfully.");
        }    
    }    
}
