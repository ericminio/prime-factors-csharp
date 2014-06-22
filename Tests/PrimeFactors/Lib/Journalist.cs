using System;
using NUnit.Framework;

namespace Tests
{
	public class Journalist
	{
        public Article Article = new TextArticle();
        public Genius Genius = new Mathematician();

        public void WriteAnArticleAboutTheNumber (int number)
        {
            Article.AboutNumber (number);
            Article.KnowingDecomposition (Genius.PrimeFactorsOf (number));
        }
	}

}

