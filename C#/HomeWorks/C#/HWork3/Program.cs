/*
//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int num) {
    
    int firstNum = num / 10000;
    int lastNum = num % 10;
        if (firstNum == lastNum) {

            int newNum = num % 10000 / 10;
            firstNum = newNum / 100;
            lastNum = newNum % 10;
            
            if (firstNum == lastNum)
                Console.WriteLine($"Число {num} является палиндромом.");
            else
                Console.WriteLine($"Число {num} не является палиндромом.");
        }
        else
            Console.WriteLine($"Число {num} не является палиндромом.");
    
    }

Console.Write("Введите число, является ли оно палиндромом?: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);

*/


/*

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(double ax, double ay, double az, double bx, double by, double bz) {

    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

}

Console.Write("Введите коордитану 'X' точки 'A': ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коордитану 'Y' точки 'A': ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коордитану 'Z' точки 'A': ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите коордитану 'X' точки 'B': ");

double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану 'Y' точки 'B': ");

double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану 'Z' точки 'B': ");

double bz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Расстояние равно: {Distance(ax, ay, az, bx, by, bz)}");

*/


/*

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Number(int num)
{
    int count = 1;
    while (count <= num) {

        Console.Write($"{Math.Pow(count, 3)}");

        Console.Write(" ");

        count++;
    }
}
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Number(num);

*/