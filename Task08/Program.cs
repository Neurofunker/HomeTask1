/*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
*/
Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number>=2)
{
while (count<=number)
{
Console.Write($"{count} ");
count=count+2;
}
}
else
{
    Console.WriteLine("Вы ввели не натуральное число или 1 ");
}