using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.QuickSort
{
    public class QuickSortHoare
    {
       static void QuickSort<T>(T[] array, int start, int end)where T : IComparable
        {
            if (start < end)
            {
                int pivot = HoarePartition(array, start, end);
                QuickSort<T>(array, start, pivot);
                QuickSort<T>(array, pivot+1, end);


            }

        }

       static int HoarePartition<T>(T[] array, int start, int end) where T : IComparable
        {
            var pivot = array[start];
            int i= start-1;
            int j= end+1;
            while (true) 
            {

                do
                {
                    i++;
                } while (array[i].CompareTo(pivot)<0);
                do
                {
                    j--;
                } while (array[j].CompareTo(pivot)>0);
                if (i >= j)
                    return j;
            
                var temp= array[i];
                array[i] = array[j];
                array[j] = temp;
            
            }
        }
        static void Print<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] numbers = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
            string[] names = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };

            QuickSort<int>(numbers,0,numbers.Length-1);
            QuickSort<string>(names,0,names.Length-1);

            Print(numbers);
            Print(names);
            Console.ReadLine(); 

        }

    }
   
}
