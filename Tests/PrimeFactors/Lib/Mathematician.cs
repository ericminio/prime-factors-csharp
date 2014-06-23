using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public class Mathematician : Genius
	{
        public List<int> PrimeFactorsOf (int number)
        {
            if (number == 1) return new List<int> ();
            return DivideGivenNumberAsMuchAsPossibleBy (2, number);
        }

        private List<int> DivideGivenNumberAsMuchAsPossibleBy (int prime, int number)
        {
            if (number % prime == 0) {
                var factors = new List<int> { prime };
                factors.AddRange (PrimeFactorsOf (number / prime));
                return factors;
            }
            return DivideGivenNumberAsMuchAsPossibleBy (prime + 1, number);
        }
	}
}

