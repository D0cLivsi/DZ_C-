// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.Write("Пон");
}
else if (day == "2")
{
    Console.Write("Вт");
}
else if (day == "3")
{
    Console.Write("Ср");
}
else if (day == "4")
{
    Console.Write("Чт");
}
else if (day == "5")
{
    Console.Write("Пт");
}
else if (day == "6")
{
    Console.Write("Сб");
}
else if (day == "7")
{
    Console.Write("Вс");
}
else
{
    Console.WriteLine("Nеверный день недели");
}