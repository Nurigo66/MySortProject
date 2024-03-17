using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.SelectionSort
{
    //Time Complexity=>0(n^2)
    //Space Complexity=>0(1)
    public class SelectionSort
    {
       
        static int[] numbers = { 52, 103, 34, 88, 23, 94, 127, 48, 56 };
        static string[] name = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };

        static void SSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int MinIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[MinIndex]) < 0)
                    {
                    MinIndex = j;
                    }
                }
               var temp = array[MinIndex];
                array[MinIndex] = array[i];
                array[i] = temp;

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
            SSort<int>(numbers);
            SSort<string>(name);

            Print<int>(numbers);
            Print<string>(name);
        }




    }
}
