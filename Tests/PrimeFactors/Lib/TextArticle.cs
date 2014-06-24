using System;
using NUnit.Framework;

namespace Tests
{
	public class TextArticle : Article
	{
        public string Text;

        public void AboutNumber (int number)
        {
            Text = number + " = ";
        }

        public void KnowingDecomposition (System.Collections.Generic.List<int> decomposition)
        {
        }      
	}
}

