
using System;
using ExcelDataReader;
using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (var stream = File.Open("data.xlsx", FileMode.Open, FileAccess.Read))
        {
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet();
                var dataTable = result.Tables[0];
                
                // Display the data
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }
                
                // Analyze the data (for example calculate the sum of a specific column)
                int sum = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    sum += Convert.ToInt32(row["Column1"]);
                }
                
                Console.WriteLine("Sum of Column1: " + sum);
            }
        }
    }
}
