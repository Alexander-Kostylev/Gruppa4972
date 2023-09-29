// ==================================================================================
//                           Задача №52
//              Задайте двумерный массив из целых чисел. 
//      Найдите среднее арифметическое элементов в каждом столбце.
// ==================================================================================


// Ввод с консоли начальных значений
int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
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

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{(array[i]):f2}\t");
    }
    Console.Write($"{(array[array.Length-1]):f2} ]");
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

double[] averageSumColumm(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        int sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum+=matrix[i,j];
        }
        result[j]=(double)sum/matrix.GetLength(0);
    }
    return result;
}

int row=readData("Введите количество строчек в массиве: ");
int columm=readData("Введите количество столбцов в массиве: ");

int lowBorder = readData("Введите нижнюю границу чисел: "); 
int highBorder = readData("Введите верхнюю границу чисел: ");

int[,] array2D=Fill2DArray(row, columm, lowBorder, highBorder);
Console.WriteLine();
Print2DArray(array2D);
double[] sumArray=averageSumColumm(array2D);
Console.WriteLine();
PrintArray(sumArray);