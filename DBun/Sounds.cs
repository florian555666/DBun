using NetCoreAudio;
namespace DBun
{
    public class Sounds
    {
        /*
        public static void CancelByEscapeKey()
        {
            ***Not working yet***
            try
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    System.Console.WriteLine("Sound gestoppt.");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
        */
        public static async void Sound()
        {
            string AlarmSound =  "/Users/florian/DBun/Soundlist/programming-a-computer-loop-323395.mp3";
            System.Console.WriteLine(AlarmSound);
            var player = new Player();
            System.Console.WriteLine("Bitte geben Sie die Nummer des Sounds ein:");
            System.Console.WriteLine("Drücken Sie Escape, um den Sound zu stoppen.");
            System.Console.WriteLine("1. Sound Alarm");
            System.Console.WriteLine("2. Sound 2 - noch nicht implementiert");
            System.Console.WriteLine("3. Sound 3 - noch nicht implementiert");
            string input = Console.ReadLine() ?? "";
            switch (input)
            {  
                case "1":
                //CancelByEscapeKey();                    
                Console.WriteLine("Sound Alarm");
                await player.Play("C:/Users/florian.partsch-1/Documents/VSCode/DBun/DBun/Soundlist/programming-a-computer-loop-323395.mp3");
                
                break;
                case "2":
                //CancelByEscapeKey();
                Console.WriteLine("Sound 2");
                await player.Play("/Users/florian/DBun/Soundlist/0011892.mp3");                
                break;
                case "3":
                //CancelByEscapeKey();
                Console.WriteLine("Sound 3");
                break;
                default:
                Console.WriteLine("Ungültige Eingabe");
                break;
            }                
        }                                   
    }
}