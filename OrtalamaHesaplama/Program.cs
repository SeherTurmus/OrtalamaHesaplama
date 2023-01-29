using System;
namespace OrtalamaHesaplama
{
    public class Program
    {        
        static void Main()
        {
            Console.WriteLine("Lütfen Fibonacci derinliğini girin : ");

            var num = decimal.Parse(Console.ReadLine());
            var sum = Fib(num);

            var ave = Math.Round(sum / (num + 1), 3);
            Console.WriteLine($"Ortalama : {ave}");
        }
        public static int Fib(decimal n)
        {
            if(n == 0 || n == 1)
                return 1;
            return Fib(n-1) + Fib(n-2);
        }
    }    
}
