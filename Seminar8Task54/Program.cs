//=======================================================================================
//                                  Задача 54
//                  Задайте двумерный массив. Напишите программу, 
//      которая упорядочит по убыванию элементы каждой строки двумерного массива.
//=======================================================================================

// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//создаем 2-х мерный массив, заполенный случайными числами
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

//печать 2Д массива
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

// сортировка 2Д массива вставками
void Sort2DArray (int[,] startArr)
{
    for (int i = 0; i < startArr.GetLength(0); i++)
    {
        for (int j = 1; j < startArr.GetLength(1); j++)
        {
            int key = startArr[i,j];
            int k = j;
            int temp;
            while ((k > 0) && (startArr[i,k - 1] > key))
            {
                temp = startArr[i,k - 1];
                startArr[i, k - 1] = startArr[i, k];
                startArr[i, k] = temp;
                k--;
            }
        }
    }
}


int rowArray = ReadData($"Введите количество строк в массиве: ");
int colummArray = ReadData($"Введите количество столбцов в массиве: ");
int minValue = ReadData($"Введите минимальное число: ");
int maxValue = ReadData($"Введите максимальное число: ");

//создаем 2-х мерный массив, заполенный случайными числами 
int[,] array = Fill2DArray(rowArray, colummArray, minValue, maxValue);
Console.WriteLine("Исходный массив:");
Print2DArray(array);

//сортируем по строчно массив, методом "вставок"
Sort2DArray(array);
Console.WriteLine("Отсортированный массив:");
Print2DArray(array);