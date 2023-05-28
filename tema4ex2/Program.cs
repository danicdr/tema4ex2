using System;

namespace test_infinit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k:");
            int k = int.Parse(Console.ReadLine());

            int[,,] mat1 = ReadMatrix(n, m, k);
            ShowMatrix(mat1);

            int[,,] mat2 = ReadMatrix(n, m, k);
            ShowMatrix(mat2);

            int[,,] mat3 = ReadMatrix(n, m, k);
            ShowMatrix(mat3);

            int[,,] addResult = AddMatrices(mat1, mat2, mat3);
            ShowMatrix(addResult);
        }

        static int[,,] ReadMatrix(int n, int m, int k)
        {
            Console.WriteLine("Introduceti matricea:");

            int[,,] result = new int[n, m, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int u = 0; u < k; u++)
                    {
                        result[i, j, u] = int.Parse(Console.ReadLine());
                    }
                }
            }

            return result;
        }
        static int[,,] AddMatrices(int[,,] mat1, int[,,] mat2, int[,,] mat3)
        {
            int n = mat1.GetLength(0);
            int m = mat1.GetLength(1);
            int k = mat1.GetLength(2);

            int[,,] result = new int[n, m, k];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int u = 0; u < k; u++)
                    {
                        result[i, j, u] = mat1[i, j, u] + mat2[i, j, u] + mat3[i, j, u];
                    }
                }
            }

            return result;
        }



        static void ShowMatrix(int[,,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int k = matrix.GetLength(2);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int u = 0; u < k; u++)
                    {
                        Console.Write(matrix[i, j, u] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

//Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m 
//k.Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura. 
// Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
//rezultatul. 
// Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
//rezultatul.