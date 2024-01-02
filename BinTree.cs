using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_A
{
    internal class BinTree
    {
        // Single member: the root of type Node
        private Node root;

        // Constructors
        // First constructor creates an empty tree with no root
        // Second constructor creates a tree with a specified root
        public BinTree()
        {
            root = null;
        }
        public BinTree(Node root)
        {
            this.root = root;
        }

        // Public methods available for class users
        public void InOrder()
        {
            inOrder(root);
        }

        public void PostOrder()
        {
            postOrder(root);
        }

        public void PreOrder()
        {
            preOrder(root);
        }

        // InOrder method implementation (private)
        private void inOrder(Node tree)
        {
            if (tree != null)
            {
                inOrder(tree.Left);
                Console.Write(tree.Data + ", ");
                inOrder(tree.Right);
            }
        }

        // PostOrder method implementation
        private void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write(tree.Data + ", ");
            }
        }

        // PreOrder method implementation
        private void preOrder(Node tree)
        {
            if (tree != null)
            {
                Console.Write(tree.Data + ", ");
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        // Private recursive method to insert an item into the tree
        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
                tree = new Node(item);
            else if (item < tree.Data)
                insertItem(item, ref tree.Left);
            else if (item > tree.Data)
                insertItem(item, ref tree.Right);
        }

        // Public method to insert an item into the tree
        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }
    }
}
