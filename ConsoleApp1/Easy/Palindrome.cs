using System.Text.RegularExpressions;

public class Palindrome
{
    public static bool palindromeChecker(string input)
    {
        char[] chars = input.ToLower().ToCharArray();
        //set pointer for the left and right
        int left = 0;
        int right = chars.Length - 1;
        //loop until left < right
        while(left < right)
        {
            //check if left is not a digit if not move to next char
            if (!Char.IsLetterOrDigit(chars[left]))
            {
                continue;
            }
            if (!Char.IsLetterOrDigit(chars[right]))
            {
                continue;
            }
            //if the characters dont match return false
            if (chars[left] != chars[right])
            {
                return false;
            }
            //increment both pointers
            left++;
            right--;
        }
        return true;
    }


    static void Palin()
    {
        string input = "racecar";
        Console.WriteLine($"Palindrome: {palindromeChecker(input)}");
    }
}