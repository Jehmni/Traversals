using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the nodes and construct the tree
            Node root = new Node(4);
            root.Left = new Node(3);
            root.Left.Left = new Node(1);
            root.Right = new Node(7);
            root.Right.Left = new Node(5);
            root.Right.Right = new Node(9);

            // Create the binary tree with the specified root
            BinTree myBinTree = new BinTree(root);

            // Perform different traversals on the binary tree and print the results
            Console.Write("InOrder Traversal: ");
            myBinTree.InOrder();
            Console.WriteLine("");
            Console.Write("PostOrder Traversal: ");
            myBinTree.PostOrder();
            Console.WriteLine("");
            Console.Write("PreOrder Traversal: ");
            myBinTree.PreOrder();
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
 
        }
    }
}
