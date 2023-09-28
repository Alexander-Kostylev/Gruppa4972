//                   Задача №51
//         Задайте двумерный массив. Найдите сумму
//      элементов, находящихся на главной диагонали (с
//          индексами (0,0); (1;1) и т.д.

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

int MainDiagSum(int[,]mtrx)
{
    int res=0;
    int min=mtrx.GetLength(0);
    if(min > mtrx.GetLength(1)) min=mtrx.GetLength(1);
    for(int i=0; i<min; i++)
    {
        res+=mtrx[i,i];
    }
    return res;
}

int row=readData("Введите необходимое количество строк: ");
int columm=readData("Введите необходимое количество столбцов: ");
int[,] matrix=Fill2DArray(row, columm, 10, 0);
Console.WriteLine("\nИсходный массив:");
Print2DArray(matrix);

int resultSum=MainDiagSum(matrix);
Console.WriteLine($"\nСумма элементов на главной диагонали равна: {resultSum}");