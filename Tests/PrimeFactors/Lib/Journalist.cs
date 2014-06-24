using System;
using NUnit.Framework;

namespace Tests
{
	public class Journalist
	{
        public Article Article = new TextArticle();
        public Genius Genius;

        public void WriteAnArticleAboutTheNumber (int number)
        {
            Article.AboutNumber (number);
        }
	}
}

