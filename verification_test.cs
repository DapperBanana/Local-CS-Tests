
using System;

class MainClass {
    public static void Main (string[] args) {
        int[] arr = {10, 22, 9, 33, 21, 50, 41, 60, 80};

        int[] lis = new int[arr.Length];
        int[] prev = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++) {
            lis[i] = 1;
            prev[i] = -1;
            for (int j = 0; j < i; j++) {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1) {
                    lis[i] = lis[j] + 1;
                    prev[i] = j;
                }
            }
        }

        int maxLength = 0;
        int maxIndex = -1;
        for (int i = 0; i < arr.Length; i++) {
            if (lis[i] > maxLength) {
                maxLength = lis[i];
                maxIndex = i;
            }
        }

        int[] longestIncreasingSubsequence = new int[maxLength];
        for (int i = maxLength - 1; i >= 0; i--) {
            longestIncreasingSubsequence[i] = arr[maxIndex];
            maxIndex = prev[maxIndex];
        }

        Console.WriteLine("The longest increasing subsequence is:");
        foreach (int num in longestIncreasingSubsequence) {
            Console.Write(num + " ");
        }
    }
}
