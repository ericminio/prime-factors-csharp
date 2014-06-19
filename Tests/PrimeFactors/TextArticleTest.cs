using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class TextArticleTest
    {
        TextArticle article;

        [SetUp]
        public void ATextArticleAboutANumber()
        {
            article = new TextArticle ();
            article.AboutNumber (42);
            article.KnowingDecomposition (new List<int> { 2, 3, 7 });
        }

        [Test]
        public void UsesTheGivenNumberInTheText ()
        {
            Assert.That (article.Text, Is.StringContaining ("42"));
        }

        [Test]
        public void UsesTheGivenDecompositionInTheText ()
        {
            Assert.That (article.Text, Is.StringContaining ("2x3x7"));
        }
    }
}

