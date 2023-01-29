using System;
namespace TriangleDraw
{
    public class Program
    {
        static void Main()
        
        {
            var x = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}