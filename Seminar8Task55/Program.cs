//=================================================================
//                      Задача 55 
//      Задайте двумерный массив. Напишите программу,
//      которая заменяет строки на столбцы. В случае, если это
//      невозможно, программа должна вывести сообщение для
//      пользователя.
//=================================================================

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

// проверка на возможность замены
bool TestArrRot(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}

// замена строк столбцами
void Rotate2Darray(int[,] mtrx, bool test)
{
    if (test)
    {
        int temp = 0;
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 1 + i; j < mtrx.GetLength(1); j++)
            {
                temp = mtrx[i, j];
                mtrx[i, j] = mtrx[j, i];
                mtrx[j, i] = temp;
            }
        }
    }
    else Console.WriteLine("Невозможно выполнить переворот матрицы!");
}

Console.Clear();

//создание матрицы
int[,] matr = Fill2DArray(5, 5, 1, 10);
//печать массива
Print2DArray(matr);
//проверка на возможность преобразования
bool test = TestArrRot(matr);
// замена строк столбцами
Rotate2Darray(matr,test);
Console.WriteLine("========================================================================================");
// печать
Print2DArray(matr);

