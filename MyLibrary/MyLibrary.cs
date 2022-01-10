using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MyLibrary
    {
        public static string NumCompare(int a, int b)
        {
            if (a > b)
                return "больше";
            if (a < b)
                return "меньше";
            else
                return "равно";
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int GetRandom()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            return value;
        }

    }
}
