using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LargestNum
{
    public static void LargestNumProg(int[] input)
    {
        int result = 0;
        for(int i = 0;i< input.Length;i++)
        {
            if (input[i] > result)
                result = input[i];
        }
        Console.WriteLine($" result = {result} ");
    }
    static void large()
    {
        int[] inputArray = { 23, 7, 2, 9, 4 };
        LargestNumProg(inputArray);
    }
}
