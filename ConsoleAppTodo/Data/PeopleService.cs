using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTodo.Models;


namespace ConsoleAppTodo.Data
{
    internal class PeopleService
    {
        //An array
        private static Person[] personArray = new Person[0];

        public Person[] person
        {
            get
            {
                return personArray;

            }
            set
            {

                personArray = value;

            }

        }

        public int size()
        {
            return personArray.Length;
        }
        public Person FindAll(int personId)
        {
            foreach (Person person in personArray)

            {
                if (person.PersonId == personId)
                {
                    return person;
                }
            }
            return null;
        }
        public Person[] RemovePersonIndex()
        {
            foreach (Person person in personArray)
            {
                personArray.Where(person => person.PersonId == personArray[0].PersonId).ToList().Remove(person);
                Array.Resize(ref personArray, personArray.Length - 1);
            }
            return personArray;
        }

    }

}
