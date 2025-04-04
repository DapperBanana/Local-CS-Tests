
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        
        if (n % 2 == 0 || n % 3 == 0) return false;
        
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        
        return true;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (n == 1) return false;
        
        for (int i = 2; i < n; i++)
        {
            if (!IsPrime(i))
                continue;
            
            int m = (int)Math.Pow(2, i) - 1;
            if (m != 0 && n % m == 0)
                return true;
        }
        
        return false;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it's a Lucas-Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine(number + " is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Lucas-Carmichael number.");
        }
    }
}
