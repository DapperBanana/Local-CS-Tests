
using System;

class Program
{
    static int LucasLehmer(int n)
    {
        int n0 = 4;
        int n1 = 14;
        int nm1 = 0;
    
        for (int i = 2; i <= n; i++)
        {
            nm1 = n0;
            n0 = n1;
            n1 = ((n1 * n1) - 2) % n;
            if (n1 < 0)
            {
                n1 += n;
            }
        }
    
        return n0;
    }

    static bool IsLucasCarmichael(int n)
    {
        if (n < 2)
        {
            return false;
        }

        int lucasNumber = LucasLehmer(n);
        
        return lucasNumber == 0;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine($"{number} is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Lucas-Carmichael number.");
        }
    }
}
