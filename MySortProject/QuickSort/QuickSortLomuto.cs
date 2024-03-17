using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.QuickSort
{
    public class QuickSortLomuto
    {  
        static void QuickSort<T>(T[] array,int start,int end)where T : IComparable
        {
            if (start < end)
            {
                int pivot = LomutoPartition(array, start, end);
                QuickSort<T>(array, start, pivot - 1);
                QuickSort<T>(array, pivot + 1, end);
            }

        }

        static int LomutoPartition<T>(T[] array, int start, int end) where T : IComparable
        {
            var pivot = array[end];
            int i= start-1;

            for (int j = start; j < end; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            var temp2 = array[i + 1];
            array[i + 1] = array[end];
            array[end] = temp2;

            return i + 1;

        }
        static void Main()
        {
            int[] numbers = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
            string[] names = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };
            QuickSort<int>(numbers,0,numbers.Length-1);
            QuickSort<string>(names,0,names.Length-1);

            Console.WriteLine(string.Join(',',numbers));
            Console.WriteLine(string.Join(',',names));


        }
    }
}
