using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[,]{  { 0,0,1,1,1,0 },
                                        { 0,0,0,0,1,1 },
                                        { 1,0,0,1,0,1 },
                                        { 1,0,1,0,0,0 },
                                        { 1,1,0,0,0,1 },
                                        { 0,1,1,0,1,0 } };
            int[] array = new int[] { 9, 7, 3, 18, 2, 6, 22, 8 };
            int[] massiv = QuickSort(array, 0, array.Length);
            Console.WriteLine($"Рассортированный массив {string.Join(",", massiv)}");
        }
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
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
        static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
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
        static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }        
    }
}
