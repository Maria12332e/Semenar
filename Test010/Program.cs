//Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine()!);


string res = ("");
if(numberB * numberB != numberA && numberA   * numberA != numberB){ // не равно
    res = ("Нет");
}

else {
    res = ("Да");
}
Console.WriteLine(res);