// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);

int fistnumber = number / 100;
int thirdnumber = number % 10;

//Console.WriteLine(number +" " + fistnumber + thirdnumber);
Console.WriteLine(fistnumber * 10 + thirdnumber + " " + number);