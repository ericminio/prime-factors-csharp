using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class MathematicianTest
    {
        Mathematician einstein;

        [SetUp]
        public void Einstein()
        {
            einstein = new Mathematician();
        }

        [Test]
        public void KnowsThatOneHasNoDecomposition ()
        {
            Assert.That (einstein.PrimeFactorsOf (1), Is.EqualTo (new List<int> { }));
        }

        [Test]
        public void KnowsTheDecompositionOfTwo()
        {
            Assert.That (einstein.PrimeFactorsOf (2), Is.EqualTo (new List<int> { 2 }));
        }

        [Test]
        public void KnowsTheDecompositionOfThree()
        {
            Assert.That (einstein.PrimeFactorsOf (3), Is.EqualTo (new List<int> { 3 }));
        }

        [Test]
        public void KnowsTheDecompositionOfEigth()
        {
            Assert.That (einstein.PrimeFactorsOf (8), Is.EqualTo (new List<int> { 2, 2, 2 }));
        }
    }
}

