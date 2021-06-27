using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4.luah_kefel_2_dims
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = (i + 1) * (j + 1);
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("  ");
            }

            Console.ReadLine();


        }

    }
}
