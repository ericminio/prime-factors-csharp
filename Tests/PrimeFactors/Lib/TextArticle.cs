using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public class TextArticle : Article
	{
        public string Text;

        public void AboutNumber (int number)
        {
            Text = number + " = ";
        }

        public void KnowingDecomposition (List<int> decomposition)
        {
        }      
	}
}

