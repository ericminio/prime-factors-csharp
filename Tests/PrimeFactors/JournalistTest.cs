using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class JournalistTest
    {
        Journalist Claire = new Journalist();

        [Test]
        public void CanWriteOneArticleAboutThePrimeFactorsDecomposition ()
        {
            Claire.WriteAnArticleAboutTheNumber (300);

            Assert.That (TheArticle.Of(Claire), IsATextArticle.Containing ("300 = 2x2x3x5x5"));
        }
    }
}

