/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
 цифру этого числа. */

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число. Попробуйте снова. Введите трехзначное число: ");
}
else
    Console.WriteLine((number % 100) / 10);
