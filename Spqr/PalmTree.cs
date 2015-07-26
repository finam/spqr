using System.Collections.Generic;

namespace Spqr
{
	class PalmTree
	{
		public PalmTree(Node root)
		{
			Root = root;
		}

		public Node Root { get; private set; }
		Dictionary<Edge,bool> _isFrond = new Dictionary<Edge, bool>();
	}
}