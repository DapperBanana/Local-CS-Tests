
using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) 
            return false;
        
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
                return false;
        }
        
        return true;
    }

    static int PowMod(int x, int y, int m)
    {
        int res = 1;
        x = x % m;
        
        while (y > 0)
        {
            if (y % 2 == 1)
                res = (res * x) % m;

            y = y >> 1; 
            x = (x * x) % m;
        }
        
        return res;
    }

    static bool IsLucasPseudoprime(int n)
    {
        if (n <= 1)
            return false;
        
        if (!IsPrime(n))
            return false;
        
        int d = 5;
        int d2 = 4;
        
        while(true)
        {
            int a = d2 * d2;
            int b = d * d;
            
            if (a > n)
                break;
                
            if (PowMod(b - 4, n - 1, n) == 0 || PowMod(b + 4, n - 1, n) == 0)
                return true;
            
            d += 1;
            d2 += 1;
        }
        
        return false;
    }

    static bool IsCarmichael(int n)
    {
        if (IsPrime(n))
            return false;
        
        for (int a = 2; a < n; a++)
        {
            if (PowMod(a, n, n) != a)
                return false;
        }
        
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (IsCarmichael(num) && IsLucasPseudoprime(num))
            Console.WriteLine($"{num} is a Lucas-Carmichael number.");
        else
            Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
    }
}
