//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCoordinates(number);

void FindCoordinates (int quarter){
    string result = "";
    if (quarter == 1){
        result = "X и Y положительныу";
    }
    else if (quarter == 2){
        result = "X положительный Y отрицательный";
    }
    else if (quarter == 3){
        result = "X отрицательный Y отрицательный";
    }
    else if (quarter == 4){
        result = "Y положительный X отрицательный ";
    }
    else {
        result = ("Ошибка");
    }
    Console.WriteLine(result);
}

