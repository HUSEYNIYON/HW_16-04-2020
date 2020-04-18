using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_04_2020
{
    class ArrayHelper <T>
    {
        public T Pop(ref T[] Array)
        {

            T[] arr = new T[Array.Length - 1];
            for (int i = 0; i < Array.Length - 1; i++)
            {
                arr[i] = Array[i];

            }
            T a = Array[Array.Length - 1];
            Array = arr;
            return a;
        }
    }
}
