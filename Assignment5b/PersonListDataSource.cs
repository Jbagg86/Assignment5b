using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    public class PersonListDataSource : IPersonDataSource
    {
        private readonly List<Person> _people;

        public PersonListDataSource()
        {
            _people = new List<Person>
            {
                new Person { Id = 1, Name = "John Baggett", Phone = "304-237-5533" },
                new Person { Id = 2, Name = "Jerry Jones", Phone = "304-222-8699" },
                new Person { Id = 3, Name = "Charlie Chapman", Phone = "681-255-6969" }
            };
        }

        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList();
        }

        public void SaveChanges()
        {
          
        }
    }
}