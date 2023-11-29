using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null) // while there is another node
            {
                before = after;
                if (value < after.Data)//if value passed through is < Root of tree
                    after = after.LeftNode; // Root = Root.LeftNode
                else if (value > after.Data)// if new node is > than root (root = 5) (4,5,6) (7)
                    after = after.RightNode; // Root = Root.RightNode (root = 6), ((4,5),6,(7))
                else
                {
                    return false; // value == after, already exists.
                }
            }

            Node newNode = new Node(); // create newNode, give it the values of the integer passed through
            newNode.Data = value;

            if (this.Root == null)//If tree is empty, make the root of the Tree equal to newNode/value
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data) // remember that before is a Node, Nodes have LeftNode,RightNode,Data
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        //Method to find value of a node
        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null) // if parent is not null
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            //if value is same as parent's value, node needs to be deleted
            else
            {
                //node with only one child or no child
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                //node with two children: get the inorder successor(smallest in the right subtree)
                parent.Data = MinValue(parent.RightNode);

                //Delete the inorder successor
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        //ORDER: node, left, right
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        //method to traverse in asc order
        // visit left subtree first, then the node, then the right tree
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        //LHS print children first
        //ORDER: left, right, node
        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
