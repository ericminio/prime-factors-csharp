using System;
using NUnit.Framework;

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
        }

        [Test]
        public void UsesTheGivenNumberInTheText ()
        {
            Assert.That (article.Text, Is.StringContaining ("42"));
        }
    }
}

