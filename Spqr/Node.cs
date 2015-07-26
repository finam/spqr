using System.Collections.Generic;

namespace Spqr
{
	class Node
	{
		public int Id { get; private set; }
		public List<Edge> AdjacentList { get; private set; } 
	}
}