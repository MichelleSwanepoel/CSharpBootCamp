using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class HomeStead
    {
        private string name;
        private string district;
        private string province;
        private string country;
        
        public HomeStead(string _name, string _district, string _province, string _country)
        {
            name = _name;
            district = _district;
            province = _province;
            country = _country;
        }


        public string accept(Visitor person)
        {
            string returnStr;
            if (person is Politician)
            {
                Politician pol = (Politician)person;

                if (pol.getParty() == "ANC")
                    return pol.visit(this);
                else
                {
                    throw new VisitorNotAllowedException("Visit method could not be called, because this visitor may not enter " + name);
                }

            }
            else
            {
                throw new VisitorNotAllowedException("Visit method could not be called, because this person is not a visitor");
            }
        }

        public string getName()
        {
            return name;
        }

    }
}
