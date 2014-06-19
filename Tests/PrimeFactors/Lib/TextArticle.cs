using System;
using NUnit.Framework;

namespace Tests
{
	public class TextArticle : Article
	{
        public int Number;
        public string Text;

        public TextArticle()
        {
            Text = Number + " = 2x2x3x5x5 !!!";
        }

        public void AboutNumber (int number)
        {

        }
	}
}

