//=====================================================================
//                   Домашнее задание
//          Пользователь вводит с клавиатуры M чисел.
//    Посчитайте, сколько чисел больше 0 ввёл пользователь.
//=====================================================================

//  Ввод значений
string ReadData(string msg)
{
    Console.Write(msg);
    string str = Console.ReadLine() ?? "0";
    return str;
}

//  Преобразование строки -> число
int[] StringToIntegerArray(string str)
{
    string[] numbes = str.Split(',');
    int[] value = new int[numbes.Length];
    for (int i = 0; i < numbes.Length; i++)
    {
        value[i] = int.Parse(numbes[i]);
    }
    return value;
}

//  Нахождение количества чисел >0
int CheckNumberGreaterZero(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > 0) count++;
    }
    return count;
}
//  Вывод результата    
void PrintData(int result)
{
    Console.WriteLine($"Ввели {result} чисел(-а) больше 0");
}

string enterValue = ReadData("Введите числа через запятую: ");
int[] valueInteger = StringToIntegerArray(enterValue);
int numbGreaterThanZero = CheckNumberGreaterZero(valueInteger);
PrintData(numbGreaterThanZero);