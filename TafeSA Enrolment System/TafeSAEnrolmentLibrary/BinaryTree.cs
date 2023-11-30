using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary 
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public bool Add(T value)
        {
            Node<T> before = null, after = this.Root;

            while (after != null) // while there is another node
            {
                before = after;
                if (value.CompareTo(after.Data) < 0)//if value passed through is < Root of tree
                    after = after.LeftNode; // Root = Root.LeftNode
                else if (value.CompareTo(after.Data) > 0)// if new node is > than root (root = 5) (4,5,6) (7)
                    after = after.RightNode; // Root = Root.RightNode (root = 6), ((4,5),6,(7))
                else
                {
                    return false; // value == after, already exists.
                }
            }

            Node<T> newNode = new Node<T>(); // create newNode, give it the values of the integer passed through
            newNode.Data = value;

            if (this.Root == null)//If tree is empty, make the root of the Tree equal to newNode/value
            {
                this.Root = newNode;
            }
            else
            {
                if (value.CompareTo(before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        //Method to find value of a node
        public Node<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }

        private Node<T> Find(T value, Node<T> parent)
        {
            if (parent != null) // if parent is not null
            {
                if (value.CompareTo(parent.Data) == 0) return parent;
                if (value.CompareTo(parent.Data) < 0)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null) return parent;

            if (key.CompareTo(parent.Data) < 0) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key.CompareTo(parent.Data) > 0)
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

        public T MinValue(Node<T> node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public T FindSmallestValue()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            Node<T> node = Root;
            T minv = node.Data;

            // Traverse to the leftmost node
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public T FindLargestValue()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            Node<T> node = Root;
            T maxv = node.Data;

            // Traverse to the rightmost node
            while (node.RightNode != null)
            {
                maxv = node.RightNode.Data;
                node = node.RightNode;
            }

            return maxv;
        }

        //ORDER: node, left, right
        public void TraversePreOrder(Node<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + "\n\n");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        //method to traverse in asc order
        // visit left subtree first, then the node, then the right tree
        public void TraverseInOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + "\n\n");
                TraverseInOrder(parent.RightNode);
            }
        }

        //LHS print children first
        //ORDER: left, right, node
        public void TraversePostOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + "\n\n");
            }
        }
    }
}
