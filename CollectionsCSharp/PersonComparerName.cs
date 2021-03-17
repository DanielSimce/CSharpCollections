using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCSharp
{
    public class PersonComparerName:IComparer
    {
        public static IComparer Default = new PersonComparerName();

        public int Compare(object x, object y)
        {
            if ((x is Person) && (y is Person))
            {
                return Comparer.Default.Compare(((Person)x).name, ((Person)y).name);
            }
            else
            {
                throw new ArgumentException("Not a person object");
            }
            
        }
    }
}
