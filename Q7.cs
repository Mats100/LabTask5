// 213034 Muneeb Shahid

using System;

class MatrixMultiply
{
    static void Main()
    {
        int[,] matrixa = new int[3, 3];
        int[,] matrixb = new int[3, 3];
        int[,] resultMatrix = new int[3, 3];

        Console.WriteLine("Enter the values for Matrix A (3x3):");
        ReadMatrix(matrixa);

        Console.WriteLine("Enter the values for Matrix B (3x3):");
        ReadMatrix(matrixb);

        MultiplyMatrice(matrixa, matrixb, resultMatrix);

        Console.WriteLine("Resultant Matrix  is (A x B):");
        PrintMatrix(resultMatrix);

        Console.ReadLine();
    }

    static void ReadMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Enter value at ({row + 1}, {col + 1}): ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void MultiplyMatrice(int[,] matrixa, int[,] matrixb, int[,] resultMatrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrixa[i, k] * matrixb[k, j];
                }
            }
        }
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}