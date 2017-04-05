using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1, j = 1, val;
            while (i < 25)
            {
                Console.Write(j + " ");
                val = i + j;
                j = i;
                i = val;
            }

            //Console.WriteLine("Please enter 5 numbers, separated by a space");
            //string numbersStr = Console.ReadLine();

            //string[] numbersArr = numbersStr.Split(' ');

            //for (int i = numbersArr.Length-1; i >= 0; i--)
            //{
            //    Console.Write(numbersArr[i] + " ");
            //}
            Console.ReadLine();
        }
    }
}
