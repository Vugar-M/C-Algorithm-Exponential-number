using System;

namespace vugar8
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            Console.WriteLine("insert your number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert your second number");
            int top = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < top; i++)
            {
                total = total * number;

            }
            Console.WriteLine(total);
        }
    }
}
