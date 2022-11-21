using System;
using ClassLibrary2; 

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 fun = new Class1();
            fun.Hello("Елизавета");
            Console.WriteLine($"Через пять лет вам будет: {fun.atf(18)}");
            Console.ReadLine();
        }
    }
}
