// ================================================================================
//                            Задание №68
//      Написать программу вычисления функции Аккермана с помощью рекурсии. 
//                  Даны два неотрицательных числа m и n.
// ================================================================================

// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вычисление функции Аккермана
int NumberOfAkkermanFunction(int m, int n)
{
  if(m == 0)
  {  
    return n + 1;
  }
    if(m > 0 && n == 0)
    {
      return NumberOfAkkermanFunction(m - 1, 1);
    }
  return NumberOfAkkermanFunction(m - 1, NumberOfAkkermanFunction(m, n - 1));
}


int numberM=ReadData("Введите число M для функции Аккермана: ");
int numberN=ReadData("Введите число N для функции Аккермана: ");

int result=NumberOfAkkermanFunction(numberM, numberN);
Console.WriteLine(result);