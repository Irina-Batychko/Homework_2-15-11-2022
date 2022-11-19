/* Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    String str = number.ToString();
    Console.WriteLine(str[2]);
}


