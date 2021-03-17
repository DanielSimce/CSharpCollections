using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCSharp
{
    public class Person:IComparable
    {
        public int age;
        public string name;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person newPerson = obj as Person;
                return this.age - newPerson.age;
            }
            else
            {
                throw new ArgumentException("Not a person object");
            }
            
        }
    }
}
