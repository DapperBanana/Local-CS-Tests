
using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        int num;
        
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if(IsHarshadNumber(num))
        {
            Console.WriteLine(num + " is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Harshad (Niven) number.");
        }
    }
    
    static bool IsHarshadNumber(int num)
    {
        int sum = 0;
        int temp = num;
        
        while(temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        
        return num % sum == 0;
    }
}
