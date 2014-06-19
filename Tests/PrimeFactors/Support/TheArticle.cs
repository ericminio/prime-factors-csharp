using System;
using NUnit.Framework;

namespace Tests
{
	public class TheArticle
	{
        public static Article Of (Journalist journalist)
        {
            return journalist.Article;
        }
	}
}

