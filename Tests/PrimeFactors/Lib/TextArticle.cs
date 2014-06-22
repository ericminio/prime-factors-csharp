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
            UpdateText ();
        }

        public void KnowingDecomposition (List<int> decomposition)
        {
            Decomposition = string.Join ("x", decomposition.ToArray ());
            UpdateText ();
        }

        void UpdateText ()
        {
            Text = Number + " = " + Decomposition + " !!!";
        }
	}
}

