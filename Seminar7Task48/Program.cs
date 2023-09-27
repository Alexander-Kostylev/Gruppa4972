// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,] Fill2DArraySumRowCol(int countRow, int countColumm)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumm];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumm; j++)
        {
            array2D[i, j] = i+j;
        }
    }

    return array2D;
}

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

int row = readData("Введите количество строк: ");
int columm = readData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArraySumRowCol(row, columm);
Print2DArray(arr2D);
