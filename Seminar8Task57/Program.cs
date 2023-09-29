// =================================================================================
// Задача №57
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// =================================================================================


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

void Print1DArr(int [] array)
{   
    for(int j=0; j<array.Length; j++)
    {
        Console.Write(j+"\t");
    }
    Console.WriteLine();
    Console.Write("[ ");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]},\t");
    }
    Console.Write($"{array[array.Length-1]} ]");

}

int[] FreqDic(int[,] arr, int len)
{
    int[] dic=new int[len];
    for(int i=0;i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
           dic[arr[i,j]]++;     
        }
    }
    return dic;
}

// создаем массив
int[,] matrix=Fill2DArray(5,5,1,10);
//печатаем массив
Print2DArray(matrix);

int[] arr=FreqDic(matrix,10);
Console.WriteLine();
Print1DArr(arr);