// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int PrintThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    int thirdDigit = num % 10;
    return thirdDigit;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третьей цифры нет!");
}
else
{
    int result = PrintThirdDigit(number);
    Console.Write(result);
}