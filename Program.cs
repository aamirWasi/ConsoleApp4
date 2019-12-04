using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a name : ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Your address : ");
            //var address = Console.ReadLine();
            //Console.WriteLine("Hello "+ name + "\t" +"your address is "+ address);
            //Console.ReadLine();

            string[] names = { "rasalooo", "adori", "gazi", "sallu", "nahidu", "azizu" };
            string result = null;
            foreach (var item in names)
            {
                result += item + " ,";
            }
            var LastCommaReduce = result.LastIndexOf(",");
            result = result.Remove(LastCommaReduce);
            //var len = names.Count();
            //Console.WriteLine();
            //Console.WriteLine($"length is {len}");
            //var count = 0;
            //foreach (var item in names)
            //{
            //    Console.WriteLine($"{item,-10}{count,-10}{item.Length}");
            //    count++;
            //}
            int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.Where(x=>x%2==1).Max());
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Sum());
            // Console.WriteLine(names.Min(x=>x.Length));
            var result1 = names.Aggregate((a, b) => a + " , " + b);
            foreach (var item in result1)
            {
                Console.Write(item);

            }
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.Write(item);

            }
        }
    }
}
