namespace CodewarsKatas
{
    public class SortBinaryTree
    {
        // URL: https://www.codewars.com/kata/52bef5e3588c56132c0003bc
        public class Node
        {
            public Node? Left;
            public Node? Right;
            public int Value;

            public Node(Node? l, Node? r, int v)
            {
                Left = l;
                Right = r;
                Value = v;
            }
        }

        public static List<int> Solution(Node? node)
        {
            var result = new List<int>();
            var nodeList = node != null ? new List<Node>() { node } : new List<Node>();

            while (nodeList.Count > 0)
            {
                var bufferNodeList = new List<Node>();

                foreach (var item in nodeList)
                {
                    if (item.Left != null) bufferNodeList.Add(item.Left);
                    if (item.Right != null) bufferNodeList.Add(item.Right);

                    result.Add(item.Value);
                }

                nodeList = bufferNodeList;
            }

            return result;
        }

        public static void Test()
        {
            Node? testNULL = null;

            foreach (var item in Solution(testNULL))
            {
                Console.WriteLine(item);
            }

            var test = new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1);

            foreach (var item in Solution(test))
            {
                Console.WriteLine(item);
            }
        }
    }
}
