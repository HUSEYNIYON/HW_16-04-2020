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
            
            Console.WriteLine("There five command to choice:");
            Console.WriteLine("1--> Delete the last element of an array!");
            Console.WriteLine("2--> Add an element in the end of an array!");
            Console.WriteLine("3--> Delete the first element of an array!");
            Console.WriteLine("4--> Add an element in the begin of an array!");
            Console.WriteLine("5--> Display a copy of an previous array!");
        ll:
            int MyChoice = Convert.ToInt32(Console.ReadLine());
            switch(MyChoice)
            {
                case 1:
                    Console.Write("Enter a size of an array: ");
                    int arrSize = Convert.ToInt32(Console.ReadLine());
                    int[] digits = new int[arrSize];
                    Random rand = new Random();
                    Console.WriteLine("Before:");
                    for (int i = 0; i < digits.Length; i++)
                    {
                        digits[i] = rand.Next(9);
                    }
                    foreach (int digit in digits)
                    {
                        Console.Write(" " + digit + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("After:");
                    ArrayHelper<int> ar = new ArrayHelper<int>();
                    ar.Pop(ref digits);
                    foreach (int digit in digits)
                    {
                        Console.Write(" " + digit + " ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Enter a size of an array: ");
                    int arrSize1 = Convert.ToInt32(Console.ReadLine());
                    int[] digits1 = new int[arrSize1];
                    Random rand1 = new Random();
                    Console.WriteLine("Before:");
                    for (int i = 0; i < digits1.Length; i++)
                    {
                        digits1[i] = rand1.Next(9);
                    }
                    foreach (int digit in digits1)
                    {
                        Console.Write(" " + digit + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("After:");
                    ArrayHelper<int> ar1 = new ArrayHelper<int>();
                    Console.WriteLine("Which number you want to add: ");
                    ar1.Push(ref digits1, Convert.ToInt32(Console.ReadLine()));
                    foreach (int digit in digits1)
                    {
                        Console.Write(" " + digit + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter a size of an array: ");
                    int arrSize2 = Convert.ToInt32(Console.ReadLine());
                    int[] digits2 = new int[arrSize2];
                    Random rand2 = new Random();
                    Console.WriteLine("Before:");
                    for (int i = 0; i < digits2.Length; i++)
                    {
                        digits2[i] = rand2.Next(9);
                    }
                    foreach (int digit in digits2)
                    {
                        Console.Write("" + digit + "\t");
                    }
                    Console.WriteLine();
                    Console.WriteLine("After:");
                    ArrayHelper<int> array2 = new ArrayHelper<int>();
                    array2.Shift(ref digits2);

                    foreach (int digit in digits2)
                    {
                        Console.Write("\t" + digit);
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter a size of an array: ");
                    int arrSize3 = Convert.ToInt32(Console.ReadLine());
                    int[] digits3 = new int[arrSize3];
                    Random rand3 = new Random();
                    Console.WriteLine("Before:");
                    for (int i = 0; i < digits3.Length; i++)
                    {
                        digits3[i] = rand3.Next(9);
                    }
                    foreach (int digit in digits3)
                    {
                        Console.Write("\t" + digit + "");
                    }
                    Console.WriteLine();
                    Console.WriteLine("After:");
                    Console.Write("Which number you want to add: ");
                    ArrayHelper<int> ar3 = new ArrayHelper<int>();
                    ar3.UnShift(ref digits3, Convert.ToInt32(Console.ReadLine()));
                    foreach (int digit in digits3)
                    {
                        Console.Write("" + digit + "\t");
                    }
                    break;

            }
            goto ll;
            Console.ReadKey();
        }
    }

   
}
