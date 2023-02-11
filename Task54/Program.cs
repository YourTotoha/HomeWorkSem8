//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            for (int k = j + 1; k < Columns; k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int ReplaceNum = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = ReplaceNum;
                }
            }
        }
    }
    Console.WriteLine();
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int NumberRows = GetNum("Введите количество строк в массиве: ");
int NumberColumns = GetNum("Введите количество столбцов в массиве: ");

int[,] Matrix = GenerateMatrix(NumberRows, NumberColumns, 0, 10);

ShowMatrix(Matrix);