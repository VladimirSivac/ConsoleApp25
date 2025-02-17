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
            //task4
            int[] arr = new int[6];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-20, 20);
            }
            foreach (var element in arr)
            {
                Console.Write($"{element}\t");
            }
        }
    }
}