using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SecondLargestNumInArray
{
    public static int? SecondLargest(int[] array)
    {
        if (array.Length < 2)
            return null;
        var sorted = array.Distinct()
            .OrderByDescending(n => n)
            .ToArray();
        return sorted.Length >= 2 ? sorted[1] : (int?)null;
    }
    static void shark()
    {
        int[] arr = { 5, 1, 8, 3 };
        SecondLargest(arr);
    }
}
