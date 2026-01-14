using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SaukhinCSharp
{
    class Program
    {
        static void Main()
        {
            // task 1: Number check
            Console.WriteLine("Enter number:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 7)
                {
                    Console.WriteLine("Hello");
                }
                else
                {
                    Console.WriteLine("Error:1. Enter number greater than 7 to get any respond"); 
                    //we should show any error what entered value is not enough for any response
                }
            }

            // task 2: Name check
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            if (name == "John") 
            {
                Console.WriteLine("Hello, John");
            }
            else
            {
                Console.WriteLine("There is no such name");
            }

            // task 3: Array input-output that are multiples of 3
            Console.WriteLine("Enter array elements separated by space:");
            string input = Console.ReadLine();
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i], out int temp))
                {
                    array[i] = temp;
                }
                else
                {
                    Console.WriteLine($"Incorrect nubmer: {parts[i]}");
                }
            }

            Console.WriteLine("Array elements which are multiples 3:");
            foreach (var item in array)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
