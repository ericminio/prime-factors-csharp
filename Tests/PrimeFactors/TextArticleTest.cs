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
        public void ATextArticle()
        {
            article = new TextArticle ();
        }

        [Test]
        public void DisplaysTheGivenNumberInTheText ()
        {
            article.AboutNumber (23);

            Assert.That (article.Text, Is.StringContaining ("23"));
        }

        [Test]
        public void DisplaysTheGivenDecompositionInTheText()
        {
            article.KnowingDecomposition (new List<int> { 2, 3, 7} );

            Assert.That (article.Text, Is.StringContaining ("2x3x7"));
        }
    }
}

