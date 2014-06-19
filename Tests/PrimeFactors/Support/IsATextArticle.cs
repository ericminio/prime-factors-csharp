using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
	public class IsATextArticle : Constraint
	{
        string expected;

        public IsATextArticle (string expected)
        {
            this.expected = expected;
        }

        public static IsATextArticle Containing (string expected)
        {
            return new IsATextArticle (expected);
        }

        public override bool Matches (object actual)
        {
            this.actual = actual;

            if (actual == null) return false;

            return true;
        }

        public override void WriteDescriptionTo (MessageWriter writer)
        {
            writer.WriteExpectedValue ("A text article containing " + expected);
        }

        public override void WriteActualValueTo (MessageWriter writer )
        {
            writer.WriteActualValue (actual);
        }
	}
}

