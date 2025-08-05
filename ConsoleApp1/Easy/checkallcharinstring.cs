public class letterCheck
{
    public static bool letterCheckProg(string input)
    {
        var result = true;
        foreach(var c in input)
        {
            if (!Char.IsLetter(c))
                result = false;
        }
        return result;
    }
    static void gorilla()
    {
        string input = "Hello123";
        Console.WriteLine(letterCheckProg(input));
    }
}