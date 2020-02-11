using System;
using System.Threading.Tasks;

namespace MyTask
{
    class Program
    {
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал равен {result}");
        }

        // определение асинхронного метода
        static async Task FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
        static void Main(string[] args)
        {
            var t = FactorialAsync(5);
            var t1 = FactorialAsync(6);
            Console.WriteLine("Некоторая работа");
            Console.Read();
        }
    }
}
