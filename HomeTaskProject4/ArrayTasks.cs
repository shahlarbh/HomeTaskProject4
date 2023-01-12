using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskProject4
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.Write("Massivinizin uzunlugunu daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            return arr;
        }

        internal void Print1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }

            Console.WriteLine();
        }

        internal int[] SqrtArray(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                {
                    count++;
                }
            }

            int[] sqrt = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                {
                    sqrt[index] = arr[i];
                    index++;
                }
            }

            return sqrt;
        }

        internal void Print(int[] sqrt)
        {
            for (int i = 0; i < sqrt.Length; i++)
            {
                Console.WriteLine($"sqrt[{i}]={sqrt[i]}");
            }
        }

    }
}
