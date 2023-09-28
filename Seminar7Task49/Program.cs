//                  Задача №49
//      Задайте двумерный массив. Найдите элементы, у
//      которых оба индекса чётные, и замените эти
//              элементы на их квадраты.

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

// Заполенение двухмерного массива случайными числами в заданном диапазоне
int[,] Fill2DArray(int countRow, int countColumm, int topDorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumm];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumm; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topDorder);
        }
    }

    return array2D;
}

// Замена четных элементов массива на квадраты этих значений
void Update2DArray(int[,] mtrx)
{
    for(int i=0; i<mtrx.GetLength(0); i+=2)
        {
            for(int j=0; j<mtrx.GetLength(1); j+=2)
            {
                 mtrx[i,j]*=mtrx[i,j];
            }
        }
}

int row=readData("Введите необходимое количество строк: ");
int columm=readData("Введите необходимое количество столбцов: ");
int[,] matrix=Fill2DArray(row, columm, 10, 0);
Console.WriteLine("Исходный массив:");
Print2DArray(matrix);
Update2DArray(matrix);
Console.WriteLine("Измененный массив:");
Print2DArray(matrix);