﻿//  Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//string mess = "Введите число: ";
//int number1 = Prompt(mess);
//
//int result = FindThirdNumber(number1);
//if (result == -1)
//{
//    Console.WriteLine("Такой цифры нет! ");
//}
//else
//{
//    Console.WriteLine($"Третья цифра числа {result}");
//}
//
//
//
//int Prompt(string message)
//{
//    Console.Clear();
//    Console.WriteLine(message);
//    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//    return num;
//}
//
//int FindThirdNumber(int num)
//{
//    if (num < 100)
//    {
//        return -1;
//
//    }
//    else
//    {
//        while (num >= 1000)
//        {
//            num = num / 10;
//        }
//        int thirdNumber = num % 10;
//        return thirdNumber;
//    }
//}



Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

 while (number > 999)
    number = number / 10;
        { 
       if(number < 100)
       {
        Console.Write ("Третий цифры нет");
       }
       else
       {
        int result = number % 10;
        Console.WriteLine(result);
       }
    }




