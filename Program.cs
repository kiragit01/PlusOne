using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlusOne
{
    internal class Program
    {
        //https://leetcode.com/problems/plus-one/description/

        static void Main(string[] args)
        {
            int[] digits = { 9,9,9,9 };
            PlusOne(digits);
            Console.ReadKey();
        }


        static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    if (i == 0)
                    {
                        int[] newdigits = new int[n + 1];
                        newdigits[0] = 1;
                        return newdigits;
                    }
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
            }
            return digits;
        }
    }
}
