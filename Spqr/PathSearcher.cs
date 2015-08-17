using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Spqr
{
	internal class PathSearcher
	{
		readonly Stack<Edge> _estack = new Stack<Edge>();
		readonly Stack<SepTriple> _tstack = new Stack<SepTriple>();
		private static readonly SepTriple EOS = null;

		public void PathSearch(Node v)
		{
			foreach (var e in v.AdjacentList)
			{
				var w = v == e.Node1 ? e.Node2 : e.Node1;
				if (!(IsFrond(e)))
				{
					if (StartsPath(e))
					{
						var deletedTriples = new List<SepTriple>();
						while (_tstack.Peek().A.Id > lowpt1(w).Id)
						{
							deletedTriples.Add(_tstack.Pop());
						}
						if (!deletedTriples.Any())
						{
							_tstack.Push(new SepTriple(Nodes[w.Id + Nd(w) - 1], lowpt1(w), v));
						}
						else
						{
							var y = deletedTriples.Max(t => t.H);
							var idToAdd = Math.Max(y.Id, w.Id + Nd(w) - 1);
							var newTriple = new SepTriple(Nodes[idToAdd], lowpt1(w), deletedTriples.Last().B);
							_tstack.Push(newTriple);
						}
						_tstack.Push(EOS);
					}

					PathSearch(w);
					_estack.Push(e);

					CheckForType1Pairs();
					CheckForType2Pairs();

					if (StartsPath(e))
					{
						while (_tstack.Pop() != EOS)
						{
						}
						var peek = _tstack.Peek();
						while (peek.A.Id != v.Id && peek.B.Id != v.Id && high(v).Id > peek.H.Id)
						{
							_tstack.Pop();
							peek = _tstack.Peek();
						}

					}
				}

				else //edge is frond
				{
					if (StartsPath(e)) {
						var deletedTriples = new List<SepTriple>();
						while (_tstack.Peek().A.Id > lowpt1(w).Id) {
							deletedTriples.Add(_tstack.Pop());
						}
						if (!deletedTriples.Any())
						{
							_tstack.Push(new SepTriple(v, w, v));
						}
						else {
							var y = deletedTriples.Max(t => t.H);
							var newTriple = new SepTriple(y, w, deletedTriples.Last().B);
							_tstack.Push(newTriple);
						}
					}

					var treeEdge = FindTreeEdge(w, v); //w is parent of v
					if (treeEdge != null)
					{
						var C = NewComponent(e, treeEdge);
						var virtEdge = NewVirtualEdge(w, v, C);
						MakeTreeEdge(virtEdge, treeEdge);
					}
				}
			}
		}

		private void CheckForType1Pairs()
		{
			throw new NotImplementedException();
		}

		private void CheckForType2Pairs()
		{
			throw new NotImplementedException();
		}

		private void MakeTreeEdge(Edge virtEdge, Edge treeEdge)
		{
			throw new NotImplementedException();
		}

		private Edge NewVirtualEdge(Node node1, Node node2, Component component)
		{
			throw new NotImplementedException();
		}

		private Component NewComponent(Edge virtEdge, Edge treeEdge)
		{
			throw new NotImplementedException();
		}

		private Node high(Node node)
		{
			throw new NotImplementedException();
		}

		private Edge FindTreeEdge(Node node1, Node node2)
		{
			throw new NotImplementedException();
		}

		private bool StartsPath(Edge edge)
		{
			throw new NotImplementedException();
		}

		public IList<Node> Nodes { get; set; }

		private int Nd(Node node)
		{
			throw new NotImplementedException();
		}

		private Node lowpt1(Node p0)
		{
			throw new NotImplementedException();
		}

		private bool IsFrond(Edge edge)
		{
			throw new NotImplementedException();
		}
	}
}