
using System;

class MainClass {
    static void Main() {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
        
        int n = arr.Length;
        int[] lis = new int[n];
        int max = 0;

        for (int i = 0; i < n; i++) {
            lis[i] = 1;
        }

        for (int i = 1; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1) {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        for (int i = 0; i < n; i++) {
            if (lis[i] > max) {
                max = lis[i];
            }
        }

        Console.WriteLine($"The length of the longest increasing subsequence is: {max}");
    }
}
