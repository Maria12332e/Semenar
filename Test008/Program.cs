// Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно


Console.WriteLine("Ввести первое число");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ввести второе число");
int numberB = int.Parse(Console.ReadLine()!);

int result = numberA % numberB;

if (result == 0)
{
    Console.WriteLine(numberA + "кратно"+ numberB);
}
else
{
    Console.WriteLine(numberA + " не кратно, остаток" +" " + result);
}