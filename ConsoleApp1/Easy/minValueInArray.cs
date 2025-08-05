using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class minValue
{
    public static int smallestN(int[] array)
    {
        var smallN = array[0];
        for(int i = 1;i < array.Length;i++)
        {
            if (array[i] < smallN)
                smallN = array[i];
        }
        return smallN;
    }
    static void triger()
    {
        int[] array = { 4, 2, 9, 1, 5 };
        Console.WriteLine($"Smallest N = {smallestN(array)}");
    }
}
