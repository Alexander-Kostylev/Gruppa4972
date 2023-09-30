//==============================================================================================
//                                     Задача 56
//                      Задайте прямоугольный двумерный массив. 
//      Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//==============================================================================================

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

// нахождение строки с минимальной суммой(подсчет суммы по строчно) и выводим номер этой строки
int FindMinRowSum(int[,] matrix)
{
    int tempSum = 0;
    int sumRow=0;
    int rowOnMinSum = 0;
    for (int i = 0;i < matrix.GetLength(0); i++)
    {
        sumRow = 0;
        for(int j = 0;j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if(i==0)  tempSum = sumRow;
        if(tempSum> sumRow)
        {
            tempSum= sumRow;
            rowOnMinSum = i;
        }
    }
    return rowOnMinSum;
}

int rowArray = ReadData($"Введите количество строк в массиве: ");
int colummArray = ReadData($"Введите количество столбцов в массиве: ");
int minValue = ReadData($"Введите минимальное число: ");
int maxValue = ReadData($"Введите максимальное число: ");


//создаем 2-х мерный массив, заполенный случайными числами 
int[,] array = Fill2DArray(rowArray, colummArray, minValue, maxValue);
Console.WriteLine("Исходный массив:");
Print2DArray(array);

//выводим номер строки с минимальной суммой
Console.WriteLine($"Строка с минимальной суммой в массиве: {FindMinRowSum(array)}");
