/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Digit (int num) {

    int n = num % 100;
    int result = n / 10;
    return result;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = Digit(number);

if(number < 99 || number > 999)
    Console.WriteLine("Некорректный ввод");
else
    Console.WriteLine($"Результат числа {number} это {digit}");

*/

/*

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Digit (int num) {

    int n = num % 10;
    int result = n;

    return result;  
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = Digit(number);


if (number > 999) {
    string str = Convert.ToString(number);
    string number2 = str[2].ToString();
    Console.WriteLine($"Результат числа {str} это {number2}");
   
}
else if (number < 100 && number >= 0) {
    Console.Write("третьей цифры нет!");
}
else if (number < 0) {
    number = number * -1;
    digit = digit * -1;
    Console.WriteLine($"Результат числа {number} это {digit}");   
}
else
    Console.WriteLine($"Результат числа {number} это {digit}");


/*

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DaysHoliday(int day) {

    bool result;
    if(day == 6 || day == 7) 
        result = true;
    else
        result = false;  

    return result;  
}

Console.Write("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
bool daysHoliday = DaysHoliday(number);

Console.Write("Является ли этот день выходным?");
Console.WriteLine();

if (daysHoliday) {
    Console.WriteLine("Да!");
}
else if (number <= 0 || number > 7) {
    Console.WriteLine("Введите цифру от 1 до 7!");
}
else
    Console.WriteLine("Нет!");

*/