using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class findSumOfDigits
{
    public static int sumOfDigits(int input)
    {
        int sum = 0;
        while(input > 0)
        {
            int num = input % 10;
            if (num > 0)
            {
                sum += num;
            }

            input /= 10;
        }
        return sum;
    }
    static void horse()
    {
        int input = 1234;
        Console.WriteLine(sumOfDigits(input));
    }
}