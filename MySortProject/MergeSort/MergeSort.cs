using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.MergeSort
{
    public class MergeSort
    {
        static void mergeSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                mergeSort(array, left, middle);
                mergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);

            }
        }

        private static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            T[] LeftArray = new T[n1];
            T[] RightArray = new T[n2];

            Array.Copy(array, left, LeftArray, 0, n1);
            Array.Copy(array, middle + 1, RightArray, 0, n2);

            int k = left;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (LeftArray[leftIndex].CompareTo(RightArray[rightIndex]) <= 0)
                {
                    Array.Copy(LeftArray, leftIndex, array, k, 1);
                    leftIndex++;

                }
                else
                {
                    Array.Copy(RightArray, rightIndex, array, k, 1);
                    rightIndex++;
                }
                k++;
            }
            while (leftIndex < n1)
            {
                Array.Copy(LeftArray, leftIndex, array, k, 1);
                leftIndex++;
                k++;
            }
            while (rightIndex < n2)
            {
                Array.Copy(RightArray, rightIndex, array, k, 1);
                rightIndex++;
                k++;
            }
        }

        static void Main()
        {
            int[] numbers = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
            string[] names = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };
            mergeSort(numbers, 0, numbers.Length - 1);
            mergeSort(names, 0, names.Length - 1);

            Console.WriteLine(string.Join(',', numbers));
            Console.WriteLine(string.Join(',', names));
            Console.ReadLine();
        }
    }
}
