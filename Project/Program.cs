void Zadacha47()
{
    //Задача 47. Задайте двумерный массив размером m×n,
    //заполненный случайными вещественными числами.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
}

void FillArray(double[,] array)
{
    Random random = new Random();
    double rows = array.GetLength(0);
    double columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.NextDouble() * 200 - 100;
        }
    }
}

void PrintArray(double[,] array)
{
    double rows = array.GetLength(0);
    double columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + ("\t"));
        }
        Console.WriteLine();
    }
}

Zadacha47();