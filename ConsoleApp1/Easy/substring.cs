public class Substring
{
    public static void substringprogram(string input,string substring)
    {
        if (input.Contains("world"))
        {
            Console.WriteLine($"True");
        }
        else
            Console.WriteLine($"False");
    }
    static void cougar()
    {
        string input = "Hello world";
        string substring = "world";
        substringprogram(input, substring);
    }
}
