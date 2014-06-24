using System;
using NUnit.Framework;
using NSubstitute;

namespace Tests
{
    [TestFixture]
    public class JournalistTest
    {
        Journalist Claire;

        [SetUp]
        public void TheJournalistClaire()
        {
            Claire = new Journalist();
        }

        [Test]
        public void CanWriteOneArticleAboutThePrimeFactorsDecomposition ()
        {
            Claire.WriteAnArticleAboutTheNumber (300);

            Assert.That (TheArticle.Of(Claire), IsATextArticle.Containing ("300 = 2x2x3x5x5"));
        }

        [Test] 
        public void ChoosesANumberToWriteAnArticleAbout()
        {
            var article = Substitute.For<Article> ();
            Claire.Article = article;
            Claire.WriteAnArticleAboutTheNumber (42);

            article.Received ().AboutNumber (42);
        }
    }
}

