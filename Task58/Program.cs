//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

void ShowMatrix(int[,] MatrixFrst, int[,] MatrixScnd)
{
    int RowsFrst = MatrixFrst.GetLength(0); //Показываем первую матрицу
    int ColumnsFrst = MatrixFrst.GetLength(1);
    for (int i = 0; i < RowsFrst; i++)
    {
        for (int j = 0; j < ColumnsFrst; j++)
        {
            Console.Write(MatrixFrst[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int RowsScnd = MatrixScnd.GetLength(0);//Показываем вторую матрицу
    int ColumnsScnd = MatrixScnd.GetLength(1);
    for (int i = 0; i < RowsScnd; i++)
    {
        for (int j = 0; j < ColumnsScnd; j++)
        {
            Console.Write(MatrixScnd[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int[,] result = new int[RowsFrst, ColumnsScnd]; //Создаем матрицу с результатами умножений
    for (int i = 0; i < RowsFrst; i++)
    {
        for (int j = 0; j < ColumnsScnd; j++)
        {
            int SumNum = 0;
            for (int k = 0; k < ColumnsFrst; k++)
            {
                SumNum = SumNum + MatrixFrst[i, k] * MatrixScnd[k, j];
            }
            result[i, j] = SumNum;
        }
    }
    for (int i = 0; i < RowsFrst; i++)
    {
        for (int j = 0; j < ColumnsScnd; j++)
        {
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int NumberRowsFirst = GetNum("Введите количество строк в массиве для 1 матрицы: ");
int NumberColumnsFirst = GetNum("Введите количество столбцов в массиве для 1 матрицы: ");

int NumberRowsSecond = GetNum("Введите количество строк в массиве для 2 матрицы: ");
int NumberColumnsSecond = GetNum("Введите количество столбцов в массиве для 2 матрицы: ");

int[,] MatrixFirst = GenerateMatrix(NumberRowsFirst, NumberColumnsFirst, 0, 10);
int[,] MatrixSecond = GenerateMatrix(NumberRowsSecond, NumberColumnsSecond, 0, 10);

if (NumberColumnsFirst != NumberRowsSecond)
{
    Console.WriteLine("Количество столбцов в первой матрице должно соответствовать количеству строк во второй матрице.");
}
else
{
    ShowMatrix(MatrixFirst, MatrixSecond);
}