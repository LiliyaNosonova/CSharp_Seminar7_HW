// Задача 1.1. Спирально заполнить двумерный массив:

void FillMultiArraySpiral(int[,] matr)
{
    int circle = 1;
    int count = 1;
    while (matr.GetLength(0) +1 >= 2 * circle)
    {
        matr[circle - 1, circle - 1] = count;
        count++;

        // вниз
        int i = circle + 1;
        while (i <= matr.GetLength(0) - circle + 1)
        {
            matr[i - 1, circle - 1] = count;
            count++;
            i++;
        }
        //вправо
        i = circle + 1;
        while (i <= matr.GetLength(1) - circle + 1)
        {
            matr[matr.GetLength(0) - circle, i - 1] = count;
            count++;
            i++;
        }

        //вверх
        i = matr.GetLength(0) - circle;
        while (i >= circle)
        {
            matr[i - 1, matr.GetLength(1) - circle] = count;
            count++;
            i--;
        }

        //влево
        i = matr.GetLength(0) - circle;
        while (i > circle)
        {
            matr[circle - 1, i - 1] = count;
            count++;
            i--;
        }

        circle++;
    }
}

void PrintMultiArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}      ");
        }
        System.Console.WriteLine();
    }
}
int Size = 4;
int[,] RealMatrix = new int[Size, Size];
FillMultiArraySpiral(RealMatrix);
PrintMultiArray(RealMatrix);