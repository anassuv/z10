using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 999 || n < 100)
            {
                Console.WriteLine("число не трёхзначное");
            }
            else
            {                
                Console.WriteLine("{0}", (n % 100) / 10);
            }
            Console.ReadKey();
        }
    }
}


