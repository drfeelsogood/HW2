using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rnd = new Random();
            int number;
            
            for (int i = 0; i < myArray.Length; i++)
            {
                number = rnd.Next(20);
                if (Array.IndexOf(myArray, number) == -1)
                {
                    myArray[i] = number;
                    Console.WriteLine(myArray[i]);
                }
                else
                {
                    i--;
                }                
            }
            number = myArray.Max();
            Console.WriteLine("Biggest number is: " + number.ToString());
            Console.ReadKey();
        }
    }
}
