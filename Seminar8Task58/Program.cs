// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//создаем 2-х мерный массив, заполенный случайными числами от 1 до 10
int[,] Fill2DArray(int countRow, int countColumm)
{
    int[,] array2D = new int[countRow, countColumm];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 11);
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

//проверка совместимости матриц
bool CompatibilityMatrix(int[,] matrix1, int[,] matrix2)
{
    return(matrix1.GetLength(1)==matrix2.GetLength(0));
}

// создание результирущей матрици от перемножения первой и второй
int[,] Mult2DMatrix(int[,] matr1, int[,] matr2)
{ 
    int[,] resultMatrix = new int[matr1.GetLength(0),matr2.GetLength(1)];
    int count = matr1.GetLength(1);
    for(int i = 0;i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0;j < resultMatrix.GetLength(1);j++)
        {
            int k = 0;
            while (k<count)
            {
                resultMatrix[i, j] += matr1[i, k] * matr2[k, j];
                k++;
            }
        }
    }
    return resultMatrix;
}

//ввод параметров для первой матрици
int rowArrFerstMtrx = ReadData($"Введите количество строк в 1 матрице: ");
int colummArrFerstMtrx = ReadData($"Введите количество столбцов в 1 матрице: ");
//ввод параметров для второй матрици
int rowArrSecondMtrx = ReadData($"Введите количество строк в 2 матрице: ");
int colummArrSecondMtrx = ReadData($"Введите количество столбцов в 2 матрице: ");


//создаем и заполняем первую матрицу
int[,] arrayFerst = Fill2DArray(rowArrFerstMtrx, colummArrFerstMtrx);
//создаем и заполняем вторую матрицу
int[,] arraySecond = Fill2DArray(rowArrSecondMtrx, colummArrSecondMtrx);

//печатаем первую матрицу
Console.WriteLine("Первая матрица:");
Print2DArray(arrayFerst);
//печатаем вторую матрицу
Console.WriteLine("Вторая матрица:");
Print2DArray(arraySecond);

// если матрицы совместимы то производим умножение, если нет то указываем на не совместимость
if (CompatibilityMatrix(arrayFerst, arraySecond))
{
    //получаем результирующую матрица от умножения первой и второй
    int[,] resultMtrx = Mult2DMatrix(arrayFerst, arraySecond);
    Console.WriteLine("Результат умножения двух матриц:");
    Print2DArray(resultMtrx);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Умножение матриц не возможно, т.к. они не совместимы!");
    Console.ResetColor();
}