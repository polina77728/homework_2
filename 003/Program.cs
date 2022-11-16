/* Задание 3
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    if (num == 1)
    {
        Console.Write("Понедельник. Рабочий день.");
    }
    if (num == 2)
    {
        Console.Write("Вторник. Рабочий день.");
    }
    if (num == 3)
    {
        Console.Write("Среда. Рабочий день.");
    }
    if (num == 4)
    {
        Console.Write("Четверг. Рабочий день.");
    }
    if (num == 5)
    {
        Console.Write("Пятница. Рабочий день.");
    }
}

else if (num == 6 || num == 7)
{
    Console.Write("Выходной");
}

else
{
    Console.Write("Ошибка ввода");
}

/*
int Sqr(int number)
{
    return number * number;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/