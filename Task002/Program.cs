// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            matrix[i, j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindMatrixElement(int[,] matrix, int row, int column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == row && j == column) 
            {
                Console.WriteLine(matrix[i,j]);
                return;
            }
        }
    }
    Console.WriteLine($"{row},{column} - такого числа в массиве нет.");
}

int[,] matrix = CreateMatrix(4, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
FindMatrixElement(matrix, 5, 2);
Console.WriteLine();
FindMatrixElement(matrix, 1, 2);
Console.WriteLine();