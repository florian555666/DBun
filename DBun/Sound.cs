using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using NetCoreAudio;
namespace DBun
{
    /// <summary>
    /// Work in progress
    /// Solve the problem with the Escape key
    /// Try to stop the sound with the Escape key
    /// </summary>
    /// <returns></returns>
    public class Sound
    {    
        public static bool PressedKey()
        {
            // Check if the Escape key is pressed
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    return true;
                }
            }
            return false;
        }
        public static async void Run()
        {
            var p = new Player();
            string AlarmSound =  "DBun/Soundlist/programming-a-computer-loop-323395.mp3";
            System.Console.WriteLine(AlarmSound);
            System.Console.WriteLine("Bitte geben Sie die Nummer des Sounds ein:");
            System.Console.WriteLine("Drücken Sie Escape, um den Sound zu stoppen.");
            System.Console.WriteLine("1. Sound Alarm");
            System.Console.WriteLine("2. Sound 2 - noch nicht implementiert");
            System.Console.WriteLine("3. Sound 3 - noch nicht implementiert");
            string input = Console.ReadLine() ?? "";
            if (PressedKey())
            {
                Console.WriteLine("Escape key pressed. Stopping sound.");
                await p.Stop();
                return;
            }
            else
            {
                Console.WriteLine("Sound is playing.");
            
                switch (input)
                {                
                    case "1":
                    await p.Play(AlarmSound);
                    break;                                            
                    case "2":
                    Console.WriteLine("Sound 2");
                    break;
                    case "3":
                    Console.WriteLine("Sound 3");
                    break;
                    default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
                }
            }                
        }                                   
    }
}