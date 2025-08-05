using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseInt
{
    public static void reverseIntProg(int num)
    {
        StringBuilder reverse = new StringBuilder();
        while(num > 0)
        {
            int moduloNum = num % 10;
            reverse.Append(moduloNum);
            num /= 10;
        }
        Console.WriteLine(reverse);
    }
    static void dot()
    {
        int num = 123;
        reverseIntProg(num);
    }
}
