//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int a = (number % 100) / 10;
if (number >= 100 && number < 1000)
{
   
    Console.WriteLine(" второе число" + " " + a);
}
else
{
    Console.WriteLine("Это не трех значное число");
}