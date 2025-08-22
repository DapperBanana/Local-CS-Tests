
using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        Dictionary<string, int> data = new Dictionary<string, int>();
        data.Add("Item1", 10);
        data.Add("Item2", 20);
        data.Add("Item3", 15);
        data.Add("Item4", 30);

        foreach (var kvp in data) {
            Console.Write($"{kvp.Key}: ");
            for (int i = 0; i < kvp.Value; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
