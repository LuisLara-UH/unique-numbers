namespace UniqueNumbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            string[] inputNumbers = { "3", "3", "1", "1", "2", "2", "3", "3" };
            HashSet<ulong> uniqueNumbers = GetUniqueNumbers(inputNumbers);

            Console.WriteLine("Unique numbers:");
            foreach (var num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Processes an array of strings representing numbers and returns a HashSet of unique numbers.
        /// </summary>
        /// <param name="numbers">An array of strings representing the numbers.</param>
        /// <returns>A HashSet containing unique numbers.</returns>
        public static HashSet<ulong> GetUniqueNumbers(string[] numbers)
        {
            HashSet<ulong> uniqueNumbers = new HashSet<ulong>();

            foreach (var line in numbers)
            {
                if (ulong.TryParse(line, out ulong number))
                {
                    // Add each valid number to the HashSet, duplicates will be ignored
                    uniqueNumbers.Add(number);
                }
            }
            return uniqueNumbers;
        }
    }

}