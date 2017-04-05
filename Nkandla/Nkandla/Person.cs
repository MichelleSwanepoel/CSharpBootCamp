using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public enum Gender { Male, Female};
    public enum PersonType { Lawyer, Architect, Politician };
    public class Person
    {
        private string name;
        private int age;
        private Gender gender;
        private PersonType personType;
        private ArrayList workers;

        public Person(string _name, int _age, Gender _gender, PersonType _personType)
        {
            name = _name;
            age = _age;
            gender = _gender;
            personType = _personType;

            workers = new ArrayList();
        }

        public void setType(PersonType _personType)
        {
            personType = _personType;
        }

        public void addPerson(PersonType worker)
        {
            workers.Add(worker);
        }

        public string getName()
        {
            return name;
        }
    }
}
