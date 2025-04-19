using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace DBun;

public class DataBank
{
    public static int Test{get; set;}
    public static List<ArrayList> Kategorie = new List<ArrayList>();

    public static List<ArrayList> Hosen = new List<ArrayList>();
    
/*
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
*/

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

