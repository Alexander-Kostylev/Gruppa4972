//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// * Дополнительное задание.
// Написать программу которая из имен через 
// запятую выберет случайное имя и выведет в терминал
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Ввод имен через запятую в одноу строку
string inputData(string mes)
{
    Console.WriteLine(mes);
    string inputName = Console.ReadLine() ?? "0";
    return inputName;
}

// Разделяем строку на отдельные имена и сохраем в массив string
string[] nameAr(string listName)
{
    string[] nameOfArray = listName.Split(',');
    return nameOfArray;
}

// выбираем случайный индекс из массива имен
int randIndex(string [] arName)
{
    var rnd=new Random();
    int index=rnd.Next(1, (arName.Length)+1);
    return index;
}

// выводим случайное имя
void printName(string [] arName, int index)
{
    System.Console.WriteLine($"Выбранное имя: {arName[index]}");
}


string name = inputData("Введите список имен через запятую: ");
string[] arrayName = nameAr(name);
int ind=randIndex(arrayName);
printName(arrayName, ind);


// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Для разбора строки использовать метод string.split().
// Для выбора случайного имени метод Random.Next(1, <длинна массива имен> + 1).
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
