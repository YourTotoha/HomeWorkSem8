//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)

//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int[,,] GenerateMatrix(int Rows, int Columns, int Pages, int LowerBound, int UpperBound)
{
    int[,,] Array = new int[Rows, Columns, Pages];
    int[] Result = new int[Rows * Columns * Pages];
    int UniqNumber;
    for (int i = 0; i < Result.Length; i++)
    {
        Result[i] = new Random().Next(LowerBound, UpperBound + 1);
        UniqNumber = Result[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                if (Result[i] == Result[j])
                {
                    Result[i] = new Random().Next(LowerBound, UpperBound + 1);
                    j = 0;
                }
            }
        }
    }
    int count = 0;
    for (int l = 0; l < Rows; l++)
    {
        for (int m = 0; m < Columns; m++)
        {
            for (int n = 0; n < Pages; n++)
            {
                Array[l,m,n] = Result[count];
                count++;
            }
        }
    }
    return Array;
}

void ShowMatrix(int[,,] matrix)
{
    int Rows = matrix.GetLength(0);
    int Columns = matrix.GetLength(1);
    int Pages = matrix.GetLength(2);
    for (int k = 0; k < Pages; k++)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.WriteLine($"{matrix[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

int NumberRows = GetNum("Введите количество строк(первый индекс) в массиве: ");
int NumberColumns = GetNum("Введите количество столбцов(второй индекс) в массиве: ");
int NumberPages = GetNum("Введите количество страниц(третий индекс) в массиве: ");

int[,,] Matrix = GenerateMatrix(NumberRows, NumberColumns, NumberPages, 10, 100);

ShowMatrix(Matrix);
