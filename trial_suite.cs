
using System;

class MainClass {
    public static void Main (string[] args) {
        int[] numbers = {4, 6, 8, 12};

        int result = GetLCM(numbers);

        Console.WriteLine($"The LCM of {string.Join(",", numbers)} is {result}");
    }

    static int GetLCM(int[] numbers) {
        Array.Sort(numbers);
        int maxNum = numbers[numbers.Length - 1];
        int lcm = maxNum;

        while (true) {
            bool isLCM = true;
            foreach (int num in numbers) {
                if (lcm % num != 0) {
                    isLCM = false;
                    break;
                }
            }

            if (isLCM) {
                return lcm;
            }

            lcm += maxNum;
        }
    }
}
