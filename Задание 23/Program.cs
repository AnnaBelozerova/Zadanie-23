using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Factorial1Async(10);
                Factorial2(8);

            Console.WriteLine("Main окончил работу.");
            Console.ReadKey();

        }
        static void Factorial1(uint n)
        {
            ulong f=1;
            for (uint i = 2; i <= n; i++)
            {
                f *= i;
                Console.WriteLine("Factorial 1: {0}",f);
                Thread.Sleep(100);
            }
            Console.WriteLine("Factorial 1: Факториал числа равен: {0}", f);
        }
        static void Factorial2(uint n)
        {
            ulong f = 1;
            for (uint i = 2; i <= n; i++)
            {
                f *= i;
                Console.WriteLine("Factorial 2: {0}",f);
                Thread.Sleep(100);
            }
            Console.WriteLine("Factorial 2: Факториал числа равен: {0}", f);
        }
        static async void Factorial1Async (uint n)
        {
            Console.WriteLine("FactorialAsync начал работу");
            await Task.Run(() => Factorial1(n));
            Console.WriteLine("FactorialAsync закончил работу");
        }
    }
}
