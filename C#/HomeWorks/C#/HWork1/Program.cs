/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) {

    Console.WriteLine($"Число {a} больше числа {b}");
}
else {

    Console.WriteLine($"Число {b} больше числа {a}");
}
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a >= b && a >= c) {
    Console.WriteLine($"Максимальное число {a}");
}
else if(b >= a && b >= c) { 
    Console.WriteLine($"Максимальное число {b}");
}
else if(c >= a && c >= b) {
     Console.WriteLine($"Максимальное число {c}");
}
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Является ли число чётным?");

Console.WriteLine();

if(num % 2 == 0) {

    Console.WriteLine("Да!");
}

else  if(num % 2 == 1) {
    
    Console.WriteLine("Нет!");
}
*/


/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) {

    int current = 2;
    while(current <= num) {

        Console.Write(current + " ");
        current = current + 2;
    } 
}

else if(num < 0) {
    Console.WriteLine("Введите положительное число!");
}

else if(num == 0) {
    Console.WriteLine("Вы ввели ноль!");
}

*/
