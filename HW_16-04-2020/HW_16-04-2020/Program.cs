using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method POP:
            Console.Write("Enter a size of an array: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] digits =new int[arrSize];
            Random rand = new Random();
            Console.WriteLine("Before:");
            for(int i=0;i<digits.Length;i++)
            {
                digits[i] = rand.Next(9);
            }
            foreach(int digit in digits)
            {
                Console.Write(" "+digit+" ");
            }
            Console.WriteLine();
            Console.WriteLine("After:");
            ArrayHelper<int> ar = new ArrayHelper<int>();
            ar.Pop(ref digits);
            foreach (int digit in digits)
            {
                Console.Write(" "+digit+" ");
            }
            Console.WriteLine();
            //Calling method PUSH:
            Console.Write("Enter a size of an array: ");
            int arrSize1 = Convert.ToInt32(Console.ReadLine());
            int[] digits1 = new int[arrSize];
            Random rand1 = new Random();
            Console.WriteLine("Before:");
            for (int i = 0; i < digits1.Length; i++)
            {
                digits1[i] = rand.Next(9);
            }
            foreach (int digit in digits1)
            {
                Console.Write(" " + digit + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After:");
            ArrayHelper<string> ar1 = new ArrayHelper<string>();
            Console.WriteLine("Which number you want to add: ");
            ar.Push(ref digits1, Convert.ToInt32(Console.ReadLine()));
            foreach (int digit in digits1)
            {
                Console.Write(" "+digit+" ");
            }
            Console.ReadKey();
        }
    }

   
}
