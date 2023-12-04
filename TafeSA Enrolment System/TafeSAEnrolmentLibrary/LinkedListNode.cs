using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }


        //Override operators
        public static bool operator ==(LinkedListNode<T> x, LinkedListNode<T> y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(LinkedListNode<T> x, LinkedListNode<T> y)
        {
            return !object.Equals(x, y);
        }

        //Hashcode of LinkedListNode is now Value Hashcode
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        //override LinkedListNode Equals
        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == this.GetHashCode();
        }
    }
}
