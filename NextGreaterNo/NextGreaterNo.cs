using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterNo
{
    class NextGreaterNo
    {
        static void Main(string[] args)
        {
            char[] digits = Console.ReadLine().ToCharArray();
            Console.WriteLine("before");
            printNo(digits);
            NextGreater(digits);

        }

        private static void NextGreater(char[] digits)
        {
            int i;
            //Find the first digit that is smaller than the digit next to it.
            for (i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1])
                {
                    break;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("\nNot Possible");
                Console.ReadKey();
            }
            else
            {
                int x = digits[i - 1], min = i;
                //smallest digit on right side of (i-1)'th digit that is greater than digits[i-1]
                for (int j = i + 1; j < digits.Length; j++)
                {
                    if (digits[j] < digits[min] && digits[j] > x)
                    {
                        min = j;
                    }
                }
                //swap the numbers digits[i-1] and min
                swap(digits, i - 1, min);

                // sort the digits
                Array.Sort(digits, i, digits.Length-i);

                //print next greater no with same set of digits
                Console.WriteLine("\nafter");
                printNo(digits);
                Console.ReadKey();

            }
        }

        private static void printNo(char[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
            }
        }

        private static void swap(char[] digits, int v, int min)
        {
            char temp = digits[v];
            digits[v] = digits[min];
            digits[min] = temp;
        }
    }
}