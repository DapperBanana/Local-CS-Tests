
using System;

class MainClass {
    public static void Main (string[] args) {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

        int[] LIS = new int[arr.Length];
        int maxLength = 0;

        for (int i = 0; i < arr.Length; i++) {
            LIS[i] = 1;
            for (int j = 0; j < i; j++) {
                if (arr[i] > arr[j] && LIS[i] < LIS[j] + 1) {
                    LIS[i] = LIS[j] + 1;
                }
            }
            maxLength = Math.Max(maxLength, LIS[i]);
        }

        Console.WriteLine("The length of the longest increasing subsequence is: " + maxLength);
    }
}
