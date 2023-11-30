using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Search
    {
      
        public static int BinarySortedSearch<T>(T[] myArray, T target) where T : IComparable<T>
        {
            Sort.SelectionSortAsc(myArray);
            int min = 0;
            int max = myArray.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                if (myArray[mid].CompareTo(target) == 0) // if target is found, return index mid
                    return mid;
                if (myArray[mid].CompareTo(target) > 0) // check if target is in upper half of search
                    min = mid + 1; 
                else
                    max = mid - 1; // else target is in lower half, raise max to mid - 1
            } while (min <= max);
            return -1; // -1 is returned if no match is found
        }

        public static int LinearSearch<T>(T[] myArray, T target) where T : IComparable<T> // Allows us to use the CompareTo method
        {

            int i = 0;
            bool found = false;
            while (!found && i < myArray.Length) // while not found and not end of array
            {
                if (myArray[i].CompareTo(target) == 0)
                {
                    found = true;
                }
                else
                    i++; // no match found, move to next element in array
            }
            if (i < myArray.Length)
                return i; // target found
            else
                return -1; // return -1 if not found
        }
    }
}
