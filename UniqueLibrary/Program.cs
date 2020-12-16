// You use an unique library which performs unique and complex calculations.
// You need to calculate the result for each element of the array and print it to the console.
// The problem is that the method provided by the library sometimes cannot complete the calculation
// and hangs in an infinite loop. Unfortunately, this library is no longer supported and is well
// protected against decompilation. Since the library is truly unique, we cannot find a replacement
// for it.
// Tasks:
// 1 - Print result of calculation foreach input value to the console.
// 2 - Come up with workaround for the issue described above.
// 3 - If the library does not return control, print to the console the message "An error occurred
//     while getting the result for the {input_value}". Try two more times to get the result for
//     the given value. In case of three unsuccessful attempts, continue the calculation for other
//     input values
using System;
using System.Linq;

namespace UniqueLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = Enumerable.Range(1, 1000).ToArray();

            // todo Make sure this approach doesn't work. Make your own solution instead.
            foreach (var item in array)
            {
                Console.WriteLine(CalculateSomethingMarvelous(item));
            }

            Console.ReadKey();
        }

        // You are not able to change this method
        private static string CalculateSomethingMarvelous(int someValue)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            var result = rnd.Next(int.MaxValue);

            if (result > int.MaxValue >> 2)
            {
                return $"{someValue}: result = {result}";
            }

            while (true)
            {
            }
        }
    }
}