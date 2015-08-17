using System;
using System.Collections.Generic;

namespace Spqr
{
	internal class Node
	{
		public int Id { get; private set; }
		public List<Edge> AdjacentList { get; private set; }
	}
}