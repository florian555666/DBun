using System;
using DBun;
public class CopyMMethod
{
    static char[] resultBuffer = new char[1];
    public static void Copy()
    {        
        Console.WriteLine("Write a string to copy the first character:");
        System.Console.WriteLine("Write exit to exit the process.");
        string EingabeString1 = Console.ReadLine() ?? "";
        if (EingabeString1 == "exit")                       
        {
            MainClass.Program();
        }
        else if (EingabeString1 == ".")
        {
            MainClass.Program();
        }
        else if  (EingabeString1.Length > 0)
        {
            // Copy the first character of EingabeString1 to resultBuffer
            resultBuffer = new char[1];
            resultBuffer[0] = EingabeString1[0];
            Console.WriteLine($"First character copied: {resultBuffer[0]}");
            System.Console.WriteLine("Use the paste command to paste the copied character.");
        }
        else
        {
            Console.WriteLine("No character copied. Please use the copy command first.");
        }
    }
    public static void Paste()
    {
        Console.WriteLine("Try to paste the copied character...");
            if (resultBuffer[0] == '\0')
        {
            Console.WriteLine("No character copied. Please use the copy command first.");
        }
        else if (resultBuffer[0] != '\0')
        {
            Console.WriteLine($"Pasted character: {resultBuffer[0]}");                
        }
        else
        {
            Console.WriteLine("No character copied. Please use the copy command first.");
        }
    }         
}
