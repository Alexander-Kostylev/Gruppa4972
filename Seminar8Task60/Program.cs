// ==============================================================================================================
//                                        Задание 60
//                  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//      Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//                                  Массив размером 2 x 2 x 2.
// ==============================================================================================================

//проверка на совпадение числа с уже используемыми в массиве
int CheckRandomValue(int value, int[] arr)
{
    return Array.IndexOf(arr, value);
}

// создание и заполнение 3-х мерного массива неповторяющимися числами
int[,,] Create3DArray()
{
    int[,,] arr3D = new int[2, 2, 2];
    int[] tempArray = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
    int count = 0;
    
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                do
                {
                    arr3D[i, j, k] = new Random().Next(10, 100);                                                     
                }
                while (CheckRandomValue(arr3D[i, j, k], tempArray) != -1);
                tempArray[count] = arr3D[i, j, k];
                count++;
            }
        }
    }
    return arr3D;
}

// Печать 3-х мерного массива
void Print3DArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)              //слой
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)          //строка
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)      //столбец
            {
                Console.Write($"{arr3D[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//создание 3-х мерного массива и заполнение неповторяющиемеся числами
int[,,] arr3D = Create3DArray();

// печать 3-х мерного массива
Print3DArray(arr3D);

