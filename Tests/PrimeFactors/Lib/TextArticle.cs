using System;
using NUnit.Framework;

namespace Tests
{
	public class TextArticle : Article
	{
        public int Number;
        public string Decomposition;
        public string Text;

        public void AboutNumber (int number)
        {
            Number = number;
            Text = Number + " = " + Decomposition + " !!!";
        }
	}
}

