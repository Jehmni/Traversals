using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_A
{
    internal class Node
    {
        // Class members
        private int data; // Private variable to hold the data value of the node
        public Node Left, Right; // References to the left and right child nodes

        // Constructor for the class
        public Node(int data)
        {
            this.data = data; // Set the data value of the node
            Left = null; // Initialize the left child node to null
            Right = null; // Initialize the right child node to null
        }

        // Get-Set method for the private variable data
        public int Data
        {
            get { return data; } // Get the data value of the node
            set { data = value; } // Set the data value of the node
        }
    }
}