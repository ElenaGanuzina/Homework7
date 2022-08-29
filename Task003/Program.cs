// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

double[] FindColumnAverage(int[,] matrix)
{
    int length = matrix.GetLength(1);
    double[] array =  new double[length];
    for (int i = 0; i < length; i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        array[i] = sum / matrix.GetLength(0);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
    }
    Console.WriteLine(".");
}

int[,] matrix = CreateMatrix(4, 5, 0, 10);
PrintMatrix(matrix);
double[] array = FindColumnAverage(matrix);
PrintArray(array);