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
            //task2
            int[] arr = {3, -1, 5, 6, 8 };
            // int[] arr = new int[] {3, -3, 6, 4, -9};
            foreach(var element in arr)
            {
                Console.Write($"{element}\t");
            }
        }
    }
}