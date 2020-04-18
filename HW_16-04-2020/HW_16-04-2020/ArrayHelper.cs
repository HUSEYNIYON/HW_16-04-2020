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

            T[] array = new T[Array.Length - 1];
            for (int i = 0; i < Array.Length - 1; i++)
            {
                array[i] = Array[i];

            }
            T a = Array[Array.Length - 1];
            Array = array;
            return a;
        }

        public void Push(ref T[] Array, T vr)
        {
            T[] array = new T[Array.Length + 1];
            for (int i = 0; i < Array.Length; i++)
            {
                array[i] = Array[i];

            }
            array[array.Length - 1] = vr;
            Array = array;
        }


    }
}
