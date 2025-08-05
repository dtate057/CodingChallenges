using System.Runtime.InteropServices;

public class ValidateProg
{
    public static bool PasswordChecker(string password)
    {
        if(password.Length < 8)
        {
            return false;
        }
        var hasUpper = false;
        var hasLower = false;
        var hasDigit = false;
        foreach(var ch in password)
        {
            if(Char.IsUpper(ch))
            {
                hasUpper = true;
            }           
            if (Char.IsLower(ch))
            {
                hasLower = true;
            }
            if (Char.IsDigit(ch))
            {
                hasDigit = true;
            }
        }
        return (hasUpper && hasLower && hasDigit) ? true : false;
    }
    static void boom()
    {
        string password = "password";
        Console.WriteLine(PasswordChecker(password));
    }
}
