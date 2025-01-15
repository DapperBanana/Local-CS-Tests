
using System;

namespace ConeVolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, height, volume;
            
            Console.WriteLine("Enter the radius of the cone:");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the cone:");
            height = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * radius * radius * height / 3;

            Console.WriteLine($"The volume of the cone is: {volume}");
        }
    }
}
