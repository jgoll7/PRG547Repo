using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Sort
    {

        public static void BubbleSort<T>(T[] numbers)where T: IComparable<T>
        {
            T temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) > 0)
                    {
                        //swap the numbers
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        public static void SelectionSortAsc<T>(T[] arr) where T : IComparable<T>
        {
            T temp;
            int minIndex;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                        minIndex = j;
                }
                //swap
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void SelectionSortDesc<T>(T[] arr) where T : IComparable<T>
        {
            T temp;
            int minIndex;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) > 0)
                        minIndex = j;
                }
                //swap
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }




    }

}
