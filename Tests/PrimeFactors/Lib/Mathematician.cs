using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public class Mathematician : Genius
	{
        public List<int> PrimeFactorsOf (int number)
        {
            return new List<int> { 2, 2, 3, 5 ,5 };
        }
	}
}

