//============================================================================
//                          Задача 62. 
//       Написать программу, которая заполнит спирально массив.
//           Разбор решения. РЕШЕНИЕ ВЗЯТО У ТАТЬЯНЫ!!!
//============================================================================


// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем двумерный массив спирально
int[,] FillSpiralArray(int rows, int columns)//, int topBorder, int downBorder
{
    int[,] array = new int[rows, columns];
    int value = 1;
    
    // Границы массива
    int left = 0, right = columns - 1, top = 0, bottom = rows - 1; 
    
    // Пока не заполнены все ячейки
    while (value <= rows * columns)
    {
        // Заполняем верхнюю строку слева направо
        for (int i = left; i <= right && value <= rows * columns; i++)
        {
            array[top, i] = value;
            value++;
        }
        top++;

        // Заполняем правый столбец сверху вниз
        for (int i = top; i <= bottom && value <= rows * columns; i++)
        {
            array[i, right] = value;
            value++;
        }
        right--;

        // Заполняем нижнюю строку справа налево
        for (int i = right; i >= left && value <= rows * columns; i--)
        {
            array[bottom, i] = value;
            value++;
        }
        bottom--;

        // Заполняем левый столбец снизу вверх
        for (int i = bottom; i >= top && value <= rows * columns; i--)
        {
            array[i, left] = value;
            value++;
        }
        left++;
    }
    
    return array;
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

int rowArr=ReadData($"Введите количество строк в масииве: ");
int columnArr=ReadData($"Введите количество столбцов в масииве: ");

int[,] spiralArray=FillSpiralArray(rowArr,columnArr);
Console.WriteLine();
Print2DArray(spiralArray);