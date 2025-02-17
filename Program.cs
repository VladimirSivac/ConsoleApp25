using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Компьютерный практикум № 25
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 3
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}