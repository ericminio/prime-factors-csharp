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
            if (number % 2 == 0) {
                var factors = new List<int> { 2 };
                return factors;
            }
            return null;
        }
	}
}

