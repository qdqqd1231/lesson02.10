using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;  
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
        static public void Main()
        {
            int[] arr = new int[10];
            Random r = new Random(100);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next();
                Console.Write(arr[i] + "\n");
            };

            int[] sortedArr = QuickSort(arr, 0, arr.Length - 1);
            Console.ReadKey();
            Console.WriteLine($"Sorted array:\n {string.Join("\n", sortedArr)}");
            Console.ReadKey();
        }
    }
}

