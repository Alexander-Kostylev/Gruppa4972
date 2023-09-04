// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


// запрос дня недели от системы
// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));


Console.WriteLine("Enter day number");

int day = int.Parse(Console.ReadLine() ?? "0");

string[] dayOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if (day >= 1 && day < 8)
{
    Console.WriteLine(dayOfWeek[day - 1]);
}
else
{
    Console.WriteLine("День введе не верно, введите число от 1 до 7");
}