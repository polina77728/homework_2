/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int secondDigit = Number / 10 % 10;

if (Number / 100 >= 1 && Number / 100 < 10)
{
    Console.WriteLine("Число принято. ");
    Console.WriteLine($"{Number} ->  {secondDigit}");
}
else
{
    Console.WriteLine("Ошибка при вводе числа.");
}

