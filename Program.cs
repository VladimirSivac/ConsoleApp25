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
            // task1
            /*int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0; j<n; j++)
            {
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }*/
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }
        }
    }
}
