/*

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(double x, double y) {

    int quart = 0;

    if(x > 0 && y > 0) quart = 1;
    if(x < 0 && y > 0) quart = 2;
    if(x < 0 && y < 0) quart = 3;
    if(x > 0 && y < 0) quart = 4;
    return quart;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");

*/

// Работа в залах: 

/*
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Quard(int point) {

    if(quard == 1){
        Console.WriteLine("x > 0 && y > 0");
    }
    if(quard == 2){
        Console.WriteLine("x < 0 && y > 0");
    }
    if(quard == 3){
        Console.WriteLine("x < 0 && y < 0");
    }
    if(quard == 4){
        Console.WriteLine("x > 0 && y < 0");
    }
}
Console.WriteLine("input quard: ");
int quard = Convert.ToInt32(Console.ReadLine());
Quard(quard);

*/

/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double DistancePoint(double xa, double xb, double ya, double yb) {

    return Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2));
}

Console.WriteLine("input point xa: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input point ya: ");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input point xb: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input point yb: ");
double yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DistancePoint(xa, xb, ya, yb));

*/

/*
// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
//3
//149

void Number(int n) {

    int count = 1;
    while(count <= n) {

        Console.WriteLine(Math.Pow(count,2));
        count++;
    }
}
Console.WriteLine("Input N number");
int n = Convert.ToInt32(Console.ReadLine());
Number(n);

*/