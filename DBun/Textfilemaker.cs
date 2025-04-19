public class Textfilemaker
{
    public static void Textfilemake()
    {
        string path = "C:\\Users\\Public\\Documents\\DBun\\DBun.txt";
        string[] lines = { "First line", "Second line", "Third line" };
        System.IO.File.WriteAllLines(path, lines);
        Console.WriteLine("Text file created successfully.");
    }
}