// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int DelSecDigit(int num)
{
    int delLastDigit = num / 10;
    int result = delLastDigit % 10;
    return (result);
}

Console.Write("Введите число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    Console.Write("Неверное число!");
}
else
{
    int result = DelSecDigit(number);
    Console.WriteLine($"{result}");
}