using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class printmultiplicationtable
    {
    public static void multtaple(int n)
       
    {
        StringBuilder line = new StringBuilder();
        for(int i = 1;i<=10;i++)
        {
            Console.WriteLine(n + " x " + i + " = " + n * i);
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
    static void rope()
    {
        int n = 3;
        multtaple(n);
    }
    }

