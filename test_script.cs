
using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine("Enter a number to check if it is a Carmichael number:");
        int n = int.Parse(Console.ReadLine());

        if(IsCarmichael(n)){
            Console.WriteLine($"{n} is a Carmichael number.");
        } else {
            Console.WriteLine($"{n} is not a Carmichael number.");
        }
    }

    static bool IsCarmichael(int n){
        if(IsPrime(n) || n <= 2){
            return false;
        }

        for(int a = 2; a < n; a++){
            if(GCD(a, n) == 1 && ModPow(a, n-1, n) != 1){
                return false;
            }
        }

        return true;
    }

    static int ModPow(int a, int b, int n){
        int result = 1;
        while(b > 0){
            if(b % 2 == 1){
                result = (result * a) % n;
            }
            a = (a * a) % n;
            b /= 2;
        }

        return result;
    }

    static int GCD(int a, int b){
        while(b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    static bool IsPrime(int n){
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2){
            if (n % i == 0) return false;
        }

        return true;
    }
}
