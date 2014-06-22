using System;
using NUnit.Framework;
using System.Collections.Generic;

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

        public void KnowingDecomposition (List<int> decomposition)
        {
            Decomposition = string.Join ("x", decomposition.ToArray ());
            Text = Number + " = " + Decomposition + " !!!";
        }
	}
}

