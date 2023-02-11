//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateMatrix(int Rows, int Columns, int LowerBound, int UpperBound)
{
    int[,] Result = new int[Rows, Columns];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Result[i, j] = new Random().Next(LowerBound, UpperBound + 1);
        }
    }
    return Result;
}

void ShowMatrix(int[,] matrix)
{
    int Rows = matrix.GetLength(0);
    int Columns = matrix.GetLength(1);
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int Count = 0;
    int MinSum = 10 * Columns + 1; // Это максимальная возможная сумма в строке
    for (int i = 0; i < Rows; i++)
    {
        int SumColumn = 0;
        for (int j = 0; j < Columns; j++)
        {
            SumColumn = SumColumn + matrix[i, j];
        }
        if (MinSum > SumColumn)
        {
            MinSum = SumColumn;
            Count = i;
        }
    }
    Console.WriteLine($"В {Count + 1} строке самая наименьшая сумма ({MinSum})");
}

int NumberRows = GetNum("Введите количество строк в массиве: ");
int NumberColumns = GetNum("Введите количество столбцов в массиве: ");

int[,] Matrix = GenerateMatrix(NumberRows, NumberColumns, 0, 10);

ShowMatrix(Matrix);