using System;
using System.Dynamic;
using NetCoreAudio;

namespace DBun
{
    public class Countdown
    {
        public static void Run(string input, int seconds)
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
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie die Zeit in Sekunden ein:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("was möchten Sie machen?");
            Console.WriteLine("1. Countdown");
            Console.WriteLine("2. Timer - noch nicht implementiert");
            Console.WriteLine("3. Stoppuhr - noch nicht implementiert");
            Console.WriteLine("4. Wecker - noch nicht implementiert");
            string input = Console.ReadLine() ?? "";
            Run(input, seconds);
        }             
        public static void CountdownMethod(int seconds)
        {
            int i = seconds;
            Console.WriteLine("Countdown");
            for (i = seconds; i >= 0; i--)
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
    }    
}
