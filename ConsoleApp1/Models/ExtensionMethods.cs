namespace ConsoleApp1.Models;

internal static class ExtensionMethods
{
    public static bool IsPrime(this int value)
    {
        for (int i = 2; i*i < value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPowOfTwo(this int value)
    {
        for (int i = 2; i <= value; i*=2)
        {
            if (value % i == 0 && value == i)
            {
                return true;
            }
        }
        return false;
    }
}
