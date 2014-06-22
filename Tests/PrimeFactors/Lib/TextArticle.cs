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
            Decomposition = decomposition == null ? "" : string.Join ("x", decomposition);
            UpdateText ();
        }

        void UpdateText ()
        {
            Text = Number + " = " + Decomposition + " !!!";
        }
	}
}

