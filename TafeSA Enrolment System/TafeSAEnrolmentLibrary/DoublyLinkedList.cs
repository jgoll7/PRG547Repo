using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class DoublyLinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        public DoublyLinkedListNode<T> Head
        {
            get;
            private set;
        }

        public DoublyLinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> temp = Head;

            // point head to the new node
            Head = node;

            // insert rest of list behind head
            Head.Next = temp;

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        public void AddLast(DoublyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;

                // Before: Head -> 3 <-> 5 -> null
                // After:  Head -> 3 <-> 5 <-> 7 -> null
                // 7.Previous = 5
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                //Before: Head -> 3 <-> 5
                //AFter: head --------> 5

                // Head -> 3 -> null
                // Head ------> null
                Head = Head.Next;

                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                { //5.Previous was 3, now null
                    Head.Previous = null;
                }
            }
        }

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
                    //Before: Head --> 3 --> 5 --> 7
                    //        Tail = 7
                    //After:  Head --> 3 --> 5 --> null
                    //        Tail = 5
                    //Null out 5's Next pointer
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
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
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                //Head -> 3 -> 5 -> 7
                // Value = 5
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
            DoublyLinkedListNode<T> current = Head;
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

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

            //1: Empty list - do nothing
            //2: Single node: (previous is null)
            //3: Many nodes
            //    a: node to remove is the first node
            //    b: node to remove is the middle or last
            while (current != null)
            {
                //Head -> 3 -> 5 -> 7 -> null
                //Head -> 3 ------> 7 -> null
                if (current.Value.Equals(item))
                {
                    //Case 3b
                    previous.Next = current.Next;

                    //it was the end - so update Tail
                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                    else
                    {
                        //Before: Head -> 3 <-> 5 <-> 7 -> null
                        //After: Head -> 3 <--------> 7 -> null

                        // previous = 3
                        // current = 5
                        // current.Next = 7
                        // So... 7.Previous = 3
                        current.Next.Previous = previous;
                    }
                    Count--;
                }
                else
                {
                    //Case 2 or 3a
                    RemoveFirst();
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
