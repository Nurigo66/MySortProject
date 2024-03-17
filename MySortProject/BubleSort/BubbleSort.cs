﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortProject.BubleSort
{
    //Time Complexity=>0(n^2)
    //Space Complexity=>0(1)
    public class BubbleSort
    {
        static int[] numbers = { 52, 103, 34, 88, 23, 94, 127, 48, 56 };
        static string[] name = { "Leonard", "Sheldon", "Amy", "Raj", "Penny", "Howard" };
        static void BSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
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
            BSort<int>(numbers);
            BSort<string>(name);

            Print<int>(numbers);    
            Print<string>(name);
            Console.ReadLine();
        }
    }
}
