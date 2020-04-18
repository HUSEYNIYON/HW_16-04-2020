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

        public void Push(ref T[] Array1, T vr)
        {
            T[] array1 = new T[Array1.Length + 1];
            for (int i = 0; i < Array1.Length; i++)
            {
                array1[i] = Array1[i];

            }
            array1[array1.Length - 1] = vr;
            Array1 = array1;
        }

        public T Shift(ref T[] Array2)
        {
            T[] array2 = new T[Array2.Length - 1];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Array2[i + 1];

            }
            T k = Array2[0];
            Array2 = array2;
            return k;
        }


    }
}
