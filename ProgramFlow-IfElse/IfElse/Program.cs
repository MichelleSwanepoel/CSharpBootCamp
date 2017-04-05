using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notes = { 100, 50, 20, 5, 2, 1 };
            Boolean stop = false;
            string input;
            String changeStr = "";

            while(!stop)
            {
                Console.WriteLine("Paid? ");
                int paid = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Price? ");
                int price = Int32.Parse(Console.ReadLine());
                int change = paid - price;

                    for (int i = 0; i < notes.Length; i++)
                    {
                        if(change >= notes[i])
                        {
                            changeStr += notes[i] + " ";
                            change -= notes[i];
                            i--;
                        }
                    }
               

                Console.WriteLine("\n" + changeStr);

                if (Console.ReadLine() == "stop")
                    stop = true;
            }
        }
    }
}
