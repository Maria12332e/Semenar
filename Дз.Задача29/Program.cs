// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] size = new int[8];
Console.Write("[");

for (int i = 0; i < size.Length; i++)
{
        size[i] = new Random().Next(0, 100);
        Console.Write(size[i] + "," + " ");
}
Console.Write("]");

   
