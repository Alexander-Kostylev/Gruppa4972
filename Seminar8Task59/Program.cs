//=========================================================================
//                       Задача №59
//      Задайте двумерный массив из целых чисел. Напишите программу,
//               которая удалит строку и столбец,
//       на пересечении которых расположен наименьший элемент массива.
//=========================================================================

// печать двумерного массива
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

// находим минимальный элемент массива
void FindMinElem(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

// создаем новый массив без строки и столбца с минимальным элементом
int[,] Update2DArr(int[,] mtrx, int x, int y)
{
    int[,] result = new int[mtrx.GetLength(0) - 1, mtrx.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        if (i != x)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                if (j != y)
                {
                    result[m, n] = mtrx[i, j];
                    n++;
                }
            }
        }
        m++;
        n = 0;
    }
    return result;
}

//РЕШЕНИЕ
// создание начального массива
int[,] matrix =Fill2DArray(5,5,1,10);

Print2DArray(matrix);

// значения строки и столбца которые необходимо удалить из массива
int rowDelide=0;
int colummDelite=0;

// находим минимальный элемент, значение строки и стобца для этого элемента
FindMinElem(matrix, ref rowDelide, ref colummDelite);

System.Console.WriteLine();

// создаем новый массив из исходного без строки и столбца с минимальным элем. 
int[,] updateMatrix=Update2DArr(matrix, rowDelide, colummDelite);

Print2DArray(updateMatrix);