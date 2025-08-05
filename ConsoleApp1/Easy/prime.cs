using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Prime
{
    public static bool PrimeProg(int n)
    {
        if (n < 2)
            return false;
        for(int i = 2;i <= Math.Sqrt(n);i++)
        if(n % i == 0)
        {
            return false;
        }
        return true;
        
    }
    static void primeprograms()
    {
        int num = 13;
        Console.WriteLine(PrimeProg(num));
    }
}
