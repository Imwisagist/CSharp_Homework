// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 & num > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (num >= 1000 | num <= -1000)
{
    num /= 10;
}
if (num < 1000 & num > -1000)
    {
        int result = num % 10;
        Console.WriteLine(Math.Abs(result));
    }
