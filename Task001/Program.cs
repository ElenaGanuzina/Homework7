// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] matrix = new double[rowCount, columnCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[,] matrix = CreateMatrix(5, 4);
PrintMatrix(matrix);