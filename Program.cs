using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace lol
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\suzuk\Desktop\numbers.csv");

            for (int i = 0; i < csvLines.Length; i++)
            {
                Console.WriteLine(csvLines[i]);
            }
            
            Console.WriteLine();

            int arrlength = csvLines.Length;
            Console.WriteLine(arrlength);

            Console.WriteLine();

            List<int> arr = new List<int>();
            for (int i = 0; i < csvLines.Length; i++)
            {
            string userValue = csvLines[i];
            int userInt;
                if (int.TryParse(userValue, out userInt))
            {
                arr.Add(userInt);
            }

            
        }
        int sum =0;
        foreach(int i in arr)
            sum += i;
            Console.WriteLine(sum);
        

            Console.WriteLine(arr.Max());

            Console.WriteLine(arr.Min());
            
        
    }
    
}

}