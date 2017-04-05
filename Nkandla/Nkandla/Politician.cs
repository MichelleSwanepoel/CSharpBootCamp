using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Politician:Person, Visitor
    {
        private string party;
        public Politician(string _name, int _age, Gender _gender, string _party)
            :base(_name, _age, _gender, PersonType.Politician)
        {
            party = _party;
        }

        public string getParty()
        {
            return party;
        }

        public string visit(HomeStead homestead)
        {
            Console.WriteLine(base.getName() + " is visiting " + homestead.getName());
            return base.getName() + " is visiting " + homestead.getName();
        }
    }
}
