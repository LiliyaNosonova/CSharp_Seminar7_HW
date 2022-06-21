// Задача 1. В двумерном массиве целых чисел.
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillMultiArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMultiArray(int[,] matr)// Метод вывода многомерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)// matrix.GetLength(1) - количество столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();// Для вывода массива в виде таблицы 3*4
    }
}

int MinNumberMatrix(int[,] matrix) // Метод нахождения минимального элемента матрицы
{
    int Min = matrix[0, 0];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {

            if (matrix[k, l] <= Min)
            {
                Min = matrix[k, l];
            }
        }
    }
    return Min;
}

void MinPosMatrix(int[,] matrix, int[] MinR, int[] MinC, int Min) // Метод нахождения позиции минимального элемента матрицы
{
    int i = 0;
    int j = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {

            if (matrix[k, l] == Min)
            {
                if (Array.IndexOf(MinR, k + 1) == -1)
                {
                    MinR[i] = k + 1;
                    i++;
                }
                if (Array.IndexOf(MinC, l + 1) == -1)
                {
                    MinC[j] = l + 1;
                    j++;
                }
            }
        }
    }

}



void PrintNewArray(int[] Arr2, int count)
{
    for (int position = 0; position < count; position++)
    {
        System.Console.Write(Arr2[position] + " ");
    }
}



int Row = 7;
int Col = 9;
int[,] RealMatrix = new int[Row, Col];
FillMultiArray(RealMatrix);
PrintMultiArray(RealMatrix);

int nr = 0;//количество строк к удалению
int nc = 0;//количество столбцов к удалению
int[] MinRow = new int[Row * Col];
int[] MinCol = new int[Row * Col];
// for (int i = 0; i < Row * Col; i++)
// {
//     MinRow[i] = 0;
//     MinCol[i] = 0;
// }

int Minimum = MinNumberMatrix(RealMatrix);
MinPosMatrix(RealMatrix, MinRow, MinCol, Minimum);
System.Console.WriteLine($"Минимальный элемент = {Minimum}");
System.Console.WriteLine();
System.Console.WriteLine("Строка положения минимального элемента:");
nr = Array.IndexOf(MinRow, 0);
nc = Array.IndexOf(MinCol, 0);
PrintNewArray(MinRow, nr);
System.Console.WriteLine();
System.Console.WriteLine("Столбец положения минимального элемента:");
PrintNewArray(MinCol, nc);
System.Console.WriteLine();


System.Console.WriteLine($"Количество удаляемых строк: {nr}");
System.Console.WriteLine($"Количество удаляемых столбцов: {nc}");


int[,] ResultArray = new int[Row - nr, Col - nc];
int x = 0;
int y = 0;
for (int i = 0; i < Row; i++)
{
    if (Array.IndexOf(MinRow, i + 1) == -1)
    {
        for (int j = 0; j < Col; j++)
        {
            if (Array.IndexOf(MinCol, j + 1) == -1)
            {
                // System.Console.Write(RealMatrix[i, j]);
                ResultArray[x, y] = RealMatrix[i, j];
                y++;
            }
        }
        // System.Console.WriteLine();
        y = 0;
        x++;
    }
}
System.Console.WriteLine("Итоговый массив:");
PrintMultiArray(ResultArray);


