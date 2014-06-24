using System;
using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;

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
            Claire.WriteAnArticleAboutTheNumber (64);

            article.Received ().AboutNumber (64);
        }

        [Test]
        public void AsksForHelpToAGenius()
        {
            var genius = Substitute.For<Genius> ();
            Claire.Genius = genius;
            Claire.WriteAnArticleAboutTheNumber (42);

            genius.Received ().PrimeFactorsOf (42);
        }

        [Test]
        public void UsesWhatTheGeniusSaysInTheArticle()
        {
            var article = Substitute.For<Article> ();
            var genius = Substitute.For<Genius> ();
            var decomposition = new List<int> ();
            genius.PrimeFactorsOf (Arg.Any<int> ()).Returns (decomposition);
            Claire.Article = article;
            Claire.Genius = genius;
            Claire.WriteAnArticleAboutTheNumber (Arg.Any<int>());

            article.Received ().KnowingDecomposition (decomposition);
        }
    }
}

