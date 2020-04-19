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
        public void UnShift(ref T[] Array3, T put)
        {
            T[] array3 = new T[Array3.Length + 1];
            array3[0] = put;
            for (int i = 0; i < array3.Length - 1; i++)
            {
                array3[i + 1] = Array3[i];
            }
            Array3 = array3;
        }
        public static T[] Slice(T[] Arr, int BeginIndex, int EndIndex = 0)
        {
            int bb = 0, ee = 0;
            if (BeginIndex >= 0 && EndIndex >= 0)
            {
                bb = BeginIndex;
                ee = EndIndex;
            }
            else if (BeginIndex < 0 && EndIndex == 0)
            {
                bb = Arr.Length + BeginIndex;
                ee = Arr.Length;
            }
            else if (BeginIndex > Arr.Length)
            {
                bb = 0;
                ee = 0;
            }
            else if (BeginIndex >= 0 && EndIndex < 0)
            {
                bb = BeginIndex;
                ee = Arr.Length + EndIndex;
            }
            T[] Arr2 = new T[Math.Abs(ee - bb)];
            for (int i = 0; i < Arr2.Length; i++)
            {
                Arr2[i] = Arr[bb];
                bb++;
            }
            return Arr2;
        }
    }
}

