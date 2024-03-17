using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.InsertionSort
{
    public class InsertionSort
    {

        static int[] numbers = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
        static string[] name = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };

        static void ISort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                var temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        static void Print<T>(T[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            ISort<int>(numbers);
            ISort<string>(name);

            Print<int>(numbers);
            Print<string>(name);


        }



    }
}
