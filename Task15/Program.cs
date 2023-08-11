// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string CheckWeekend(int num)
{
    if (num > 7 || num < 0)
    {
        return ("Такого номера дня недели не существует!");
    }
    else if (num < 6)
    {
        return ("Нет.");
    }
    else
    {
        return ("Да.");
    }
}

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = CheckWeekend(number);
Console.Write(result);