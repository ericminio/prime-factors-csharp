using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public class Mathematician : Genius
	{
        public List<int> PrimeFactorsOf (int number)
        {
            if (number == 1) return new List<int>();
            return DivideAsMuchAsPossibleGivenNumberBy (2, number);
        }

        List<int> DivideAsMuchAsPossibleGivenNumberBy (int prime, int number)
        {
            if (number % prime == 0) {
                var factors = new List<int> { prime };
                factors.AddRange (PrimeFactorsOf (number / prime));
                return factors;
            }
            return DivideAsMuchAsPossibleGivenNumberBy(prime + 1, number);
        }
	}
}

