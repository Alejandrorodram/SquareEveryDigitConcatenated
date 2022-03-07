using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    internal class Kata
    {
        //Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

        //For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

        //Note: The function accepts an integer and returns an integer

        public static int SquareEveryDigit1(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }
            return int.Parse(output);
        }

        public static int SquareEveryDigit2(int n)
        {
            return int.Parse(String.Concat(n.ToString().Select(i => (int)Math.Pow(char.GetNumericValue(i), 2))));
        }

        public static int SquareEveryDigit3(int n)
        {
            var output = "";
            while (n != 0)
            {
                output = ((n % 10) * (n % 10)) + output;
                n /= 10;
            }
            return int.Parse(output);
        }

        public static int SquareEveryDigit4(int n)
        {
            List<int> list = new List<int>();
            do
            {
                int b = n % 10;
                n = n / 10;
                list.Insert(0, b * b);
            } while (n != 0);

            return int.Parse(string.Join("", list.ToArray()));
        }
    }
}
