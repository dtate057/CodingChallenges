using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class evenorodd
{ 
    public static void EvenOrOddProg(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"Even");
        }
        else
            Console.Write($"Odd");
    }
    static void cow()
    {
        int num = 255;
        EvenOrOddProg(num);
    }
}
