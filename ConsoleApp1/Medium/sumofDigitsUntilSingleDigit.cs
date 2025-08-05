using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumOfDigitsUntilSingleProg
{

    public static int SumOfDigitsUntilSingle(int num)
    {        
        while(num >= 10)
        {        
        int sum = 0;
        while(num > 0)
        {
            int lastdigit = num % 10;
            sum += lastdigit;
            num /= 10;
        }
            num = sum;
        }
        return num;

    }
    static void stand()
    {
        int num = 9875;
        Console.WriteLine(SumOfDigitsUntilSingle(num));
    }
}