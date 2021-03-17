using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Person("Daniel", 32));
            arrayList.Add(new Person("Miki", 25));
            arrayList.Add(new Person("MARTIN", 30));
            arrayList.Add(new Person("aTomi", 8));

            foreach (Person item in arrayList)
            {
                Console.WriteLine($"{item.name} {item.age}");
            }
            Console.WriteLine();
            arrayList.Sort();
            foreach (Person item in arrayList)
            {
                Console.WriteLine($"{item.name} {item.age}");
            }
            Console.WriteLine();
            arrayList.Sort(PersonComparerName.Default);
            foreach (Person item in arrayList)
            {
                Console.WriteLine($"{item.name} {item.age}");
            }

            Primes primes = new Primes();

            foreach (var item in primes)
            {
                Console.Write(item + " ");
            }

            foreach (var item in GetEnumerable())
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

        }


        public static IEnumerable GetEnumerable()
        {
            yield return "Daniel";
            yield return "Simonovski";
            yield return "C#";

        }
    }
}
