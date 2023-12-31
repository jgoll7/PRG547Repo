﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class LinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            // Save off the head node so we dont lose it
            LinkedListNode<T> temp = Head;

            //Point head to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                //if the list was empty then Head and Tail should both point to the new node.
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
            
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Before: head -> 3 -> 5
                // AFter: head ---------> 5

                // head -> 3 -> null
                // head ---------> null
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        // Remove last item in list
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }

        //Remove specific item
        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            // 1: Empty List - do nothing
            // 2: Single node: (previous is null)
            // 3: Many nodes
            //   a: node to remove is the first node
            //   b: node to remove is the middle or last

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    //its a node in the middle or end
                    if (previous != null)
                    {
                        // Case 3b

                        //Before: Head -> 3 -> 5 -> null
                        //After: Head -> 3 -------> null
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        // Case 2 or 3a
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }  

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

    }
}
