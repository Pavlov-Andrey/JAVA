//Урок 6. Двумерные массивы и рекурсия

/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int NumberM(int m) {
    int count = 0;
   
    for(int i = 1; i <= m; i++) {

        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0)
        count ++;
    }
    return count;   
}

int NumberM1(int m) {
    int amount = 0;
    int count = 0;
    do {
        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0)
        count++;
        amount++;
    }
    while (amount < m);
    return count;
}

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int res = NumberM1(m);

Console.WriteLine($"Количество чисел больше нуля {res}");

*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/* 
    y = 5x + 2
    y = 9x + 4
    вычитаем первое уравнение из  второго
    y - y = 5x + 2 - (9x + 4)  => 0 = -4x - 2
    y = 9x + 4
    из первого уравнения найдем х
    -4x = -2  => x = -2 / -4 = -0.5
    y = 9x + 4
    подставим х во второе уравнение
    x = -0,5
    y = 9(-0.5) + 4 => -4.5 + 4 = -0.5
    -------------
    x = -0.5
    y = -0.5
*/

/*
double[] PointAndLines(double b1, double k1, double b2, double k2) {
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);         // вычитаем первое уравнение из второго и находим "х";
    array[1] = k1 * array[0] + b1;      // подставим "х" и найдем "y";
    return array;
}
void PrintPoint(double[] array)
{
    Console.Write($"Точка пересечения = ({array[0]}; {array[1]})");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2) {
    Console.WriteLine("Прямые параллельны, точки пересечения нет.");
}
else {
    double[] result = PointAndLines(b1,k1,b2,k2);
    PrintPoint(result);
}

*/