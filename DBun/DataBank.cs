using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace DBun
{
    public class DataBank
    {
        public static int Test{get; set;}
        public static List<ArrayList> Hosen{ get; set; } = new List<ArrayList>();
        public static ArrayList Name
        {
            get
            {            
                return Name;
            } 
            set
            {
                ArrayList KatHosen = new ArrayList();
                ArrayList KatShirts = new ArrayList();
                ArrayList KatSchmuck = new ArrayList();
                KatShirts.Add("T-Shirt");
                KatShirts.Add("Hemd");
                KatShirts.Add("Pullover");
                KatHosen.Add("Jeans");
                KatHosen.Add("Shorts");
                KatHosen.Add("Chino");
                KatSchmuck.Add("Kette");
                KatSchmuck.Add("Armband");
                KatSchmuck.Add("Ring");
                Name.Add(KatHosen);
                Name.Add(KatShirts);
                Name.Add(KatSchmuck);
            }
        }
    public static ArrayList Preis { get; set; } = new ArrayList(); 
        public static ArrayList Kategorie
        { 
            get
            {
                return Kategorie;
            }
            set
            {
                ArrayList KatHosen = new ArrayList { "Jeans", "Shorts", "Chino" };
                ArrayList KatShirts = new ArrayList { "T-Shirt", "Hemd", "Pullover" };
                ArrayList KatSchmuck = new ArrayList { "Kette", "Armband", "Ring" };
                Kategorie.Add($"{string.Join(", ", KatHosen)} {string.Join(", ", KatShirts)} {string.Join(", ", KatSchmuck)}");
            }
        }
        public static string CurrentPath { get; set; } = "/Users/florian/DBun/FileTests/";
        public static string FilenameToCreate 
        {
            get
            {
                Console.WriteLine("Please Enter a Name for the File to create");
                string Filename = Console.ReadLine() ?? "";
                string pathnameToCreate = CurrentPath + Filename;
                return pathnameToCreate;            
            }
            set
            {
                string Filename = value;
                string pathnameToCreate = CurrentPath + Filename;
                using (var fileStream = System.IO.File.Create(pathnameToCreate))
                {
                    fileStream.Close();
                }
                System.Console.WriteLine("File created successfully.");            
            }
        }
        public static string FilePath 
        { 
            get
            {
                Console.WriteLine("Please Enter a Name for the File");
                string Filename = Console.ReadLine() ?? "";
                string pathnameUInput = CurrentPath + Filename;
                return pathnameUInput;
            } 
            set
            {
                string Filename = value;
                string pathnameUInput = CurrentPath + Filename;
                System.Diagnostics.Process.Start("open", pathnameUInput);
                System.Console.WriteLine("File opened successfully.");
            }
        }
        public static string FilePathToDelete 
        {   
            get
            {
                Console.WriteLine("Please Enter a Name for the File to delete");
                string Filename = Console.ReadLine() ?? "";
                string pathnameToDelete = CurrentPath + Filename;
                return pathnameToDelete;
            }
            set
            {
                string Filename = value;
                string pathnameToDelete = CurrentPath + Filename;
                if (System.IO.File.Exists(pathnameToDelete))
                {
                    System.IO.File.Delete(pathnameToDelete);
                    System.Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    System.Console.WriteLine("File not found.");
                }
            } 
        }
        public static void Run()
        {
            FilePathToDelete = FilePathToDelete;
            FilenameToCreate = FilenameToCreate;
            FilePath = FilePath;
        }
        public static void Hose(List<ArrayList> Hosen)
        {
            ArrayList HosenName = ["Jeans"];
            ArrayList HosenName2 = ["Hello"];
            Hosen.Add(HosenName);
            Hosen.Add(HosenName2);
            //Hosen   
            foreach(var list in Hosen)
            {    
                foreach(var item in list)
                {
                System.Console.WriteLine(item);          
                }   
            }
        }
        public static void DB(List<ArrayList> Kategorie)
        {
            //Kategorie 
            ArrayList KatHosen = ["Hosen"];
            ArrayList KatShirts = ["Shirts"];
            ArrayList KatSchmuck = ["Schmuck"];     
            Kategorie.Add(KatHosen);
            Kategorie.Add(KatShirts);
            Kategorie.Add(KatSchmuck); 
            foreach (var list in Kategorie)
            {                       
                foreach(var item in list)
                {
                    Console.WriteLine(item);            
                }
            }
        }    
    }
}

