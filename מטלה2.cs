using System;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string[][] matrix1 = new string[3][];
            matrix1[0] = new string[] { "main", "up", "sub" };
            matrix1[1] = new string[] { "down", "center", "up" };
            matrix1[2] = new string[] { "sub", "down", "main" };


           
            Console.WriteLine("---------foreach matrix1----------");
            foreach (string[] matrixRow in matrix1)
            {
                for (int i = 0; i < matrixRow.Length; i++)
                {
                    string matrixCol = matrixRow[i];
                    Console.Write($"[ {matrixCol} ]");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
