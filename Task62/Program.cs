//Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] GenerateMatrix(int Rows, int Columns, int LowerBound, int UpperBound)
{
    int[,] Result = new int[Rows, Columns];
    int RowStartNum = 0;
    int ColumnStartNum = 0;
    int PlusNum = 1;
    int EndRowNum = Rows - 1;
    int EndColumnNum = Columns - 1;
    while (PlusNum <= Rows * Columns)
    {
        for (int i = ColumnStartNum; i <= EndColumnNum; i++)
        {
            Result[RowStartNum, i] = PlusNum;
            PlusNum++;
        }
        RowStartNum++;

        for (int i = RowStartNum; i <= EndColumnNum; i++)
        {
            Result[i, EndColumnNum] = PlusNum;
            PlusNum++;
        }
        EndColumnNum--;

        if (RowStartNum <= EndRowNum)
        {
            for (int i = EndColumnNum; i >= ColumnStartNum; i--)
            {
                Result[EndRowNum, i] = PlusNum;
                PlusNum++;
            }
            EndRowNum--;
        }

        if (ColumnStartNum <= EndColumnNum)
        {
            for (int i = EndRowNum; i >= RowStartNum; i--)
            {
                Result[i, ColumnStartNum] = PlusNum;
                PlusNum++;
            }
            ColumnStartNum++;
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
}

//так как нас попросили ввести массив 4 на 4 в промежутке от 0 до 16
int[,] Matrix = GenerateMatrix(4, 4, 0, 16);

ShowMatrix(Matrix);
