using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumOfEven
{
    public static int sumOfEvenProg(int[] input)
    {
        int sum = 0;
        foreach(var num in input)
        {
            if(num % 2 == 0)
            {
                sum += num;
            }

        }
        return sum;
    }
    static void sum()
    {
        int[] input = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(sumOfEvenProg(input));
    }
}