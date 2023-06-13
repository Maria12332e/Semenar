// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру дня недели");
int day = int.Parse(Console.ReadLine()!);

if (day >= 1 && day <= 7)
{
    if ( day == 6 || day == 7)
    {
        Console.WriteLine("Ура, это выходной!");
    }
    else 
    {
        Console.WriteLine("Иди работать!");
    }
}
else 
{
    Console.WriteLine("Нет, такого дни недели!");
}
