using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Common
{
    [TestFixture]
    public class NUnit
    {
        [Test]
        public void CanAssert ()
        {
            Assert.That (1 + 1, Is.EqualTo (2));
        }

        [Test]
        public void CanBeExtended()
        {
            Assert.That ("Hello World", HasContent.Including ("Hello"));
        }
    }

    public class HasContent : Constraint
    {
        private string Token;
        private string Actual;

        public HasContent (string token)
        {
            this.Token = token;
        }

        public static HasContent Including (string token)
        {
            return new HasContent (token);
        }

        public override bool Matches (object actual)
        {
            this.Actual = (String) actual;
            return this.Actual.Contains (Token);
        }

        public override void WriteDescriptionTo (MessageWriter writer)
        {
            writer.WriteExpectedValue ("A string containing the folowing token: " + Token);
        }

        public override void WriteActualValueTo( MessageWriter writer )
        {
            writer.WriteActualValue (Actual);
        }
    }

}

