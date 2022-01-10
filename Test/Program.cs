using System;
using MyLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = MyLibrary.GetRandom();
            int b = MyLibrary.GetRandom();
            int c = MyLibrary.GetRandom();

            Console.WriteLine($"{a}, {b}, {c}");

            int value1 = MyLibrary.Add(a, b);
            int value2 = MyLibrary.Add(a, c);

            string result = MyLibrary.NumCompare(value1, value2);
            Console.WriteLine($"value1 {result} value2");

        }
    }
}
