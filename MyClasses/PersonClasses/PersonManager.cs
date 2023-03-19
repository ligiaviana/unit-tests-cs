using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;

            if(!string.IsNullOrEmpty(first))
            {
                if(isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }

                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Ligia", LastName = "Viana" });
            people.Add(new Person() { FirstName = "Laura", LastName = "Andrade" });
            people.Add(new Person() { FirstName = "Luis", LastName = "Prado" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Ligia", "Viana", true));
            people.Add(CreatePerson("Laura", "Andrade", true));

            return people;
        }
    }
}
