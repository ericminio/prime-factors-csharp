using System;
using NUnit.Framework;

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
    }
}

