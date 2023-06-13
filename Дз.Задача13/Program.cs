//  Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

 while (number > 999)
    number = number / 10;
    { 
       if(number < 100)
       {
        Console.Write("Третий цифры нет");
       }
       else
       {
        int result = number % 10;
        Console.WriteLine(result);
       }
    }
