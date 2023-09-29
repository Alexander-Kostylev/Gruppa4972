// ===========================================================================================================
//                                 Домашнее задание к семинару 7.
//      Основное: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//      Дополнительное (со *): При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16).
// ===========================================================================================================

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double[,] Fill2DArray(int countRow, int countColumm, int downBorder, int topDorder)
{
    double[,] array2D = new double[countRow, countColumm];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topDorder)+new Random().NextDouble();
        }
    }
    return array2D;
}

void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Yellow,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Black};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
            Console.Write($"{matrix[i, j]:f2} \t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int numRow = readData("Укажите количество строк в массиве: ");
int numColumm = readData("Укажите количество столбцов в массиве: ");

int lowBorder = readData("Введите нижнюю границу чисел: "); 
int highBorder = readData("Введите верхнюю границу чисел: ");

double[,] array2D = Fill2DArray(numRow, numColumm, lowBorder, highBorder);
Print2DArrayColor(array2D);