// Выводит случайное число из отрезка (10, 99)
// и показывает наибольшую цифру числа
void Variant1()
{
    Console.WriteLine("Способ 1");

    System.Random numberGenerator = new System.Random();
    int num = numberGenerator.Next(10, 99);

    Console.WriteLine(num);

    int firstDigit = num / 10;
    int secondDigit = num % 10;

    Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
}

void Variant2() 
{
    Console.WriteLine("Способ 2");

    System.Random numberGenerator1 = new System.Random();
    int num1 = numberGenerator1.Next(10, 99);

    Console.WriteLine(num1);

    Console.WriteLine((num1 / 10 > num1 % 10) ? (int)(num1 / 10) : (int)(num1 % 10));
}

void Variant3()
{
    Console.WriteLine("Способ 3");

    System.Random numberGenerator = new System.Random();
    int num = numberGenerator.Next(10, 99);

    Console.WriteLine(num);

   char[] digitChar=num.ToString().ToCharArray();
   Console.WriteLine((int)digitChar[0]>digitChar[1]?digitChar[0]:digitChar[1]);
}

// Variant1();
// Variant2();
Variant3();