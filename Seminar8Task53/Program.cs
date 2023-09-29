//===================================================================
//                  Задача 53.
//      Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
//===================================================================

// Вывод массива в консоль
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Заполнение массива двумерного массива случайными вещественными числами
int[,] Fill2DArray(int countRow, int countColumm, int downBorder, int topDorder)
{
    int[,] array2D = new int[countRow, countColumm];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topDorder);
        }
    }
    return array2D;
}

void Change2DArray(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] array2D = Fill2DArray(10, 10, 1, 10);
Print2DArray(array2D);
Change2DArray(array2D);
Console.WriteLine("==================================================================================");
Print2DArray(array2D);