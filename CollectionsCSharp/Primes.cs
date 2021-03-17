using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCSharp
{
    public class Primes
    {
        public int min;
        public int max;
        public Primes(): this(2, 50) { }
        
        public Primes(int min,int max)
        {
            if (min < 2)
            {
                min = 2;
            }
            else
            {
                this.min = min;
                this.max = max;
            }
        }

        public  IEnumerator GetEnumerator()
        {
            for (int possiblePrime = min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for (int possibleFactor = 2; possibleFactor <= Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
                {
                    if (possiblePrime % possibleFactor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrime;
                }
            }
        }
    }
}
