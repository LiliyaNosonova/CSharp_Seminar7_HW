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
    int Min = matrix[1, 1];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            
            if (matrix[k, l] < Min) Min = matrix[k, l];

        }

    }
    return Min;
}

int[,] RealMatrix = new int[3, 4];
FillMultiArray(RealMatrix);
PrintMultiArray(RealMatrix);
int Minimum = MinNumberMatrix(RealMatrix);
System.Console.WriteLine(Minimum);
