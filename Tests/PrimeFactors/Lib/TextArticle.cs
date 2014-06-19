using System;
using NUnit.Framework;

namespace Tests
{
	public class TextArticle : Article
	{
        public string Text;

        public TextArticle()
        {
            Text = "300 = 2x2x3x5x5 !!!";
        }
	}
}

