using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class MathematicianTest
    {
        Mathematician Einstein;

        [SetUp]
        public void TheMathematicianEinstein()
        {
            Einstein = new Mathematician ();
        }

        [Test]
        public void KnowsThatOneHasNoDecomposition ()
        {
            Assert.That (Einstein.PrimeFactorsOf (1), Is.EqualTo (new List<int> ()));
        }

        [Test]
        public void KnowsThePrimeFactorsOf2 ()
        {
            Assert.That (Einstein.PrimeFactorsOf (2), Is.EqualTo (new List<int> { 2 } ));
        }

        [Test]
        public void KnowsThePrimeFactorsOf8 ()
        {
            Assert.That (Einstein.PrimeFactorsOf (8), Is.EqualTo (new List<int> { 2, 2, 2 } ));
        }

        [Test]
        public void KnowsThePrimeFactorsOf300 ()
        {
            Assert.That (Einstein.PrimeFactorsOf (300), Is.EqualTo (new List<int> { 2, 2, 3, 5, 5 } ));
        }
    }
}

