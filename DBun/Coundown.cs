using System;
using System.Dynamic;
using NetCoreAudio;

namespace DBun
{

    public class Countdown
    {
        public static void run(string input, int seconds)
        {
          
 
            switch (input)
            {
                case "1":
                    Console.WriteLine("Countdown");
                    CountdownMethod(seconds);
                    break;
                case "2":
                    Console.WriteLine("Timer");
                    TimerMethod(seconds);
                    break;
                case "3":
                    Console.WriteLine("Stoppuhr");
                    StopwatchMethod();
                    break;
                case "4":
                    Console.WriteLine("Wecker");
                    AlarmMethod(seconds);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;

            }
        }
    /*    public static bool PressedKey {get{
            return Console.ReadKey(true).Key == ConsoleKey.Escape;
         }
         set{
            PressedKey = Console.ReadKey(true).Key == ConsoleKey.Escape;
            if (PressedKey == true)
            {
                Console.WriteLine("Escape gedrückt");
            }
            else
            {
                Console.WriteLine("Escape nicht gedrückt");
            }
        }

        }
        */
        public static void start()
        {
            Console.WriteLine("Bitte geben Sie die Zeit in Sekunden ein:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("was möchten Sie machen?");
            Console.WriteLine("1. Countdown");
            Console.WriteLine("2. Timer");
            Console.WriteLine("3. Stoppuhr");
            Console.WriteLine("4. Wecker");
            Console.WriteLine("5. Sound");
            string input = Console.ReadLine() ?? "";
            run(input, seconds);
        }




        
         
        
        public static async void Sound()
        {

            string AlarmSound =  "/Users/florian/DBun/Soundlist/programming-a-computer-loop-323395.mp3";
            System.Console.WriteLine(AlarmSound);

            var player = new Player();
            System.Console.WriteLine("Bitte geben Sie die Nummer des Sounds ein:");
            System.Console.WriteLine("Drücken Sie Escape, um den Sound zu stoppen.");
            System.Console.WriteLine("1. Sound Alarm");
            System.Console.WriteLine("2. Sound 2");
            System.Console.WriteLine("3. Sound 3");
            string input = Console.ReadLine() ?? "";

            bool readkeys = Console.ReadKey(true).Key == ConsoleKey.Escape;
            System.Console.WriteLine(readkeys);
            switch (readkeys)
            {
                case true:
                if (readkeys == true)
                {
                    Console.WriteLine("Sound Alarm");
                    await player.Play(AlarmSound);
                    break;
                }
                else
                {
                switch (input)
                {  
                    case "1":
                    
                    Console.WriteLine("Sound Alarm");
                    await player.Play("/Users/florian/DBun/Soundlist/programming-a-computer-loop-323395.mp3");
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
                break;
                }                                                
            } 
        }       
                /*
            string soundpath = "/Users/florian/DBun/Soundlist/programming-a-computer-loop-323395.mp3";

            // Create an audio player
            var player = new Player();

            try
            {
            // Play the sound file
            await player.Play(soundpath);
            }
            catch (Exception ex)
            {
            Console.WriteLine($"Error playing sound: {ex.Message}");
            }
            */            
            public static void CountdownMethod(int seconds)
            {
                Console.WriteLine("Countdown");
                for (int i = seconds; i >= 0; i--)
                {
                    Console.WriteLine($"{i} Sekunden verbleibend");
                    System.Threading.Thread.Sleep(1000); // 1 Sekunde warten
                }
            }
            public static void TimerMethod(int seconds)
            {
                Console.WriteLine("Timer");
                for (int i = seconds; i >= 0; i--)
                {
                    Console.WriteLine("Zeit abgelaufen!");
                }
            }
            public static void StopwatchMethod()
            {
                Console.WriteLine("Stoppuhr");
                DateTime startTime = DateTime.Now;
                Console.WriteLine("Drücken Sie eine Taste, um die Stoppuhr zu stoppen...");
                Console.ReadKey();
                TimeSpan elapsedTime = DateTime.Now - startTime;
                Console.WriteLine($"Gestoppte Zeit: {elapsedTime}");
            }
            public static void AlarmMethod(int seconds)
            {
                Console.WriteLine("Wecker");
                for (int i = seconds; i >= 0; i--)
                {
                    System.Console.WriteLine($"{seconds - i} Sekunden vergangen");
                }

            }
    /*
            public static void run(string input)
            {
                System.Console.WriteLine("Was möchten Sie machen?");
                System.Console.WriteLine("1. Countdown");
                System.Console.WriteLine("2. Timer");
                System.Console.WriteLine("3. Stoppuhr");
                System.Console.WriteLine("4. Wecker");
                input = Console.ReadLine() ?? "";
                Console.WriteLine("Bitte geben Sie die Zeit in Sekunden ein:");
                int seconds = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case "1":
                    Console.WriteLine("Countdown");
                    CountdownMethod(seconds);
                    break;
                    case "2":
                    Console.WriteLine("Timer");
                    TimerMethod(seconds);
                    break;
                    case "3":
                    Console.WriteLine("Stoppuhr");
                    StopwatchMethod();
                    break;
                    case "4":
                    Console.WriteLine("Wecker");
                    AlarmMethod(seconds);
                    break;
                    default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            
                }
            }
        */
    }    
}
