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
            Console.ReadKey();
        }
    }

   
}
