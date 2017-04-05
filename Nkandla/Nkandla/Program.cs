using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Program
    {
        static void Main(string[] args)
        {
            Politician helen = new Politician("Helen Zille", 50, Gender.Female, "DA");
            Politician julius = new Politician("Julius Malema", 55, Gender.Male, "EFF");
            Politician jacob = new Politician("Jacob Zuma", 70, Gender.Male, "ANC");

            HomeStead nkandla = new Nkandla("Nkandla", "uThungulu", "KwaZulu-Natal", "South Africa");
            try
            {
               nkandla.accept(helen);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                nkandla.accept(jacob);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                nkandla.accept(julius);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
