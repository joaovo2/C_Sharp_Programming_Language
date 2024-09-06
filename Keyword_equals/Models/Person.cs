using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_equals.Models
{
    internal class Person
    {
        public string Name;
        public int Age;

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person AnotherPerson = (Person)obj;
            return Name == AnotherPerson.Name && Age == AnotherPerson.Age;
        }
    }
}
