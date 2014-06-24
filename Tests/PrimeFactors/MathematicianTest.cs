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
    }
}

