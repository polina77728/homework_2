/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
string Number = Console.ReadLine();
int length = Number.Length;

if (length >= 3)
{
    Console.WriteLine(Number[2]);
}
else
{
    Console.WriteLine("У данного числа нет третьей цифры");
}