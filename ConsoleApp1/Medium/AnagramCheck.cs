
  public class AnagramCheckClass
    {
    public static bool AnagramCheck(string input1, string input2)
    {
        if(input1.Length != input2.Length)
                return false;

        var inputSortedToCharArray = input1.ToCharArray();
        Array.Sort(inputSortedToCharArray);
        var input2Sorted = input2.ToCharArray();
        Array.Sort(input2Sorted);
        for(int i = 0; i < input1.Length;i++)
        {
            if (inputSortedToCharArray[i] != input2Sorted[i])
                return false;
        }
        return true;
        
    }
    static void closet()
    {
        var input1 = "listen";
        var input2 = "sileyt";
        Console.WriteLine(AnagramCheck(input1, input2));
    }
}
