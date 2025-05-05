
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 1 || number > 3999)
        {
            Console.WriteLine("Number out of range (1-3999)");
        }
        else
        {
            string romanNumeral = "";

            while (number > 0)
            {
                if (number >= 1000)
                {
                    romanNumeral += "M";
                    number -= 1000;
                }
                else if (number >= 900)
                {
                    romanNumeral += "CM";
                    number -= 900;
                }
                else if (number >= 500)
                {
                    romanNumeral += "D";
                    number -= 500;
                }
                else if (number >= 400)
                {
                    romanNumeral += "CD";
                    number -= 400;
                }
                else if (number >= 100)
                {
                    romanNumeral += "C";
                    number -= 100;
                }
                else if (number >= 90)
                {
                    romanNumeral += "XC";
                    number -= 90;
                }
                else if (number >= 50)
                {
                    romanNumeral += "L";
                    number -= 50;
                }
                else if (number >= 40)
                {
                    romanNumeral += "XL";
                    number -= 40;
                }
                else if (number >= 10)
                {
                    romanNumeral += "X";
                    number -= 10;
                }
                else if (number >= 9)
                {
                    romanNumeral += "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumeral += "V";
                    number -= 5;
                }
                else if (number >= 4)
                {
                    romanNumeral += "IV";
                    number -= 4;
                }
                else
                {
                    romanNumeral += "I";
                    number -= 1;
                }
            }

            Console.WriteLine($"Roman numeral: {romanNumeral}");
        }
    }
}
