using System;

namespace practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            array1[2] = 8;
            array1[0] = 15;

            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(i + " " + array1[1]);
            }

            for (int j = 0; j < array1.Length; j++)
            {
                array1[j] = j * 4;
            }
            foreach(int row in array1)
            {
                Console.WriteLine(row);
            }

            string[] paises = new string[5] { "EL Salvador", "Mexico", "Chile", "Colombia", "venezuela" };
            foreach(string pais in paises)
            {
                Console.WriteLine(pais);


            }
            
        }
    }
}
