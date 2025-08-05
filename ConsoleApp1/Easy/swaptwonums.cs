using System;
public class swaptwonums
    {
    public static void swap(int a, int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"a = {a},b = {b}");
    }
    static void curl()
    {
        int a = 3;
        int b = 5;
        swap(a, b);
    }
    
}
