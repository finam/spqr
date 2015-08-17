namespace Spqr
{
	internal class SepTriple
	{
		public SepTriple(Node h, Node a, Node b)
		{
			H = h;
			A = a;
			B = b;
		}
		
		public Node H { get; private set; }
		public Node A { get; private set; }
		public Node B { get; private set; }
	}
}