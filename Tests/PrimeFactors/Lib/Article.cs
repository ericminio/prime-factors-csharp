using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public interface Article
	{
        void AboutNumber (int number);

        void KnowingDecomposition (List<int> decomposition);
	}
}

