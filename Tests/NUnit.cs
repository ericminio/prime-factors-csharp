using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class NUnit
    {
        [Test]
        public void CanAssert ()
        {
            Assert.That (1 + 1, Is.EqualTo (2));
        }
    }
}

