using System;
using System.Numerics;
using System.Linq;

namespace _01.arrayExamplesTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Reversed : ");
            int[] array = {1, 2, 3, 4, 6, 5, 7, 8 };
            for (int i = array.Length - 1; i>=0 ; i--)
            {
                int elements = array[i];
                Console.WriteLine("index number {0} -> items value {1}", i, elements);
            }
        }
    }
}
