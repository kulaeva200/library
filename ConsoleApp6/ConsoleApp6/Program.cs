using System;
using ClassLibrary2;

namespace ConsoleApp6
{
    class Program
    {
        static long F(int n) 

        {

            if (n == 0 || n == 1)

                return 1;   

            else return n * F(n - 1);  

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Факториал n-ого числа:");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            long f = F(n);
          
            Console.WriteLine("{0}!={1}", n, f); 
            Console.ReadLine();
            Class1 fun = new Class1();
            fun.Hello("Елизавета");
            Console.WriteLine($"Через пять лет вам будет: {fun.atf(18)}");
            Console.ReadLine();
        }
    }
}
