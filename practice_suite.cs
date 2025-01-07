
using System;
using System.Collections.Generic;
using System.IO;
using ExcelDataReader;

namespace ExcelAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "data.xlsx"; // Path to your Excel file
            var data = ReadExcelFile(filePath);

            if (data != null)
            {
                AnalyzeData(data);
            }
        }

        static List<List<string>> ReadExcelFile(string filePath)
        {
            List<List<string>> data = new List<List<string>>();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            List<string> rowData = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetValue(i)?.ToString());
                            }
                            data.Add(rowData);
                        }
                    } while (reader.NextResult());
                }
            }

            return data;
        }

        static void AnalyzeData(List<List<string>> data)
        {
            // Analyze the data here
            int rowCount = data.Count;
            int columnCount = data[0].Count;

            Console.WriteLine($"Number of rows: {rowCount}");
            Console.WriteLine($"Number of columns: {columnCount}");

            // Additional analysis can be done based on the data
        }
    }
}
