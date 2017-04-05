using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number");
            int upper = Int32.Parse(Console.ReadLine());
            int mover = upper;
            int mod;
            int total = 0;

            while (mover > 0)
            {
                mod = mover % 2;
                switch (mod)
                {
                    case (0):
                        Console.WriteLine("Adding " + mover);
                        total += mover;
                        mover--;
                        break;
                    default:
                        Console.WriteLine("Not Adding " + mover);
                        mover--;
                        break;
                }
                    
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
