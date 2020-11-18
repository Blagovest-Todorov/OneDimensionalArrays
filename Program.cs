using System;
using System.Numerics;
using System.Linq;

namespace _01.arrayExamplesTasks
{
    class Program
    {
        static void  Main(string[] args)
       {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            
            for (int i = 1; i < numbers.Length ; i*= 2, i++)
            {
                //numbers[i] = i * i;
                int number = numbers[i];
                
                Console.WriteLine("index : {0}-> number :{1}",i, number);
            }
        }
    }
}
