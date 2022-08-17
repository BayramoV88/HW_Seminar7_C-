internal class Program
{
    private static void Main(string[] args)
    {
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

        void Zadacha50()
        {
            //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.

        }

        void Zadacha52()
        {
            //Задайте двумерный массив из целых чисел.
            //Найдите среднее арифметическое элементов в каждом столбце.

            Random random = new Random();
            int rows = random.Next(4, 6);
            int columns = random.Next(4, 6);
            int[,] array = new int[rows, columns];
            FillArray(array, 0, 10);
            PrintArray(array);
            FindAverage(array);
        }

        //Zadacha47();
        Zadacha52();
    }

    static void FillArray(double[,] array)
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

    static void FillArray(int[,] array, int startNum = -10, int finishNum = 10)
    {
        Random random = new Random();
        finishNum++;
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(startNum, finishNum);
            }
        }
    }

    static void PrintArray(double[,] array)
    {
        double rows = array.GetLength(0);
        double columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(Math.Round(array[i, j], 2) + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void FindAverage(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum = sum + array[i, j];
            }
            Math.Round((sum = sum / rows), 2);
            Console.WriteLine($"cреднее арифметическое элементов {j+1}-го столбца равно {sum}");
        }
    }
}