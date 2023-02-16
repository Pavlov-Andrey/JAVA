/*

int n = 5;

Console.WriteLine("number is " + n);

Console.WriteLine("number is " + n " and it is good");

Console.WriteLine($"number is {n} and it is good");
*/

/*Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine()); // всегда ввод является строкой.

Console.WriteLine("Your number is  " + n); // вывод 
*/


//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второг


/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32 (Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2) {

    Console.WriteLine("YES");
}
else {

    Console.WriteLine("NO");
}
*/

/*
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

if(number > 0) {
    current = -number;
}
else {
    current = number;
    number *= -1;
}

while(current <= number) {

    Console.Write(current + " ");
    current ++;
}
*/

/*
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 1000 && n < 1000) {

    int lastDigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {n % 10}");
} 
else {

    Console.WriteLine("Uncorrent input!");
}

*/

