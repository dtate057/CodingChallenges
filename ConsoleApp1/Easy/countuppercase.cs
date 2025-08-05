public class countUppercase
{
    public static void uppercaseCount(string input)
    {
        int count = 0;
        foreach(var c in input)
        {
            if (char.IsUpper(c))
                count++;
        }
      Console.WriteLine($"The count is  {count}");
    }
    static void poodle()
    {
        string input = "Hello WORLD";
        uppercaseCount(input);
    }
}
