
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 1, 6 };
        List<int> uniqueNumbers = RemoveDuplicates(numbers);
        
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
    
    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> uniqueList = new List<T>();
        
        foreach (T item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                uniqueList.Add(item);
            }
        }
        
        return uniqueList;
    }
}
