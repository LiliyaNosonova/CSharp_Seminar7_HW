// Задача 3. Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

void FillMultiArray(int[,,] matr)
{
    int count = 10;
    int xar = 3;
    int yar = 5;
    int zar = 6;

    for (int x = 0; x < xar; x++)
    {
        for (int y = 0; y < yar; y++)
        {
            for (int z = 0; z < zar; z++)
            {
                matr[x, y, z] = count;
                count = count + 1;
                System.Console.WriteLine($"Элемент ({x},{y},{z}) = {matr[x, y, z]}");
            }
        }

    }
}


void PrintMultiArray(int[,,] matr)
{
    int xar = 3;
    int yar = 5;
    int zar = 6;

    for (int z = 0; z < zar; z++)
    {
        for (int x = 0; x < xar; x++)
        {
            for (int y = 0; y < yar; y++)
            {
                System.Console.WriteLine($"Элемент ({x},{y},{z}) = {matr[x, y, z]}");
            }
        }

    }
}



int[,,] RealMatrix = new int[3, 5, 6];
FillMultiArray(RealMatrix);
PrintMultiArray(RealMatrix);