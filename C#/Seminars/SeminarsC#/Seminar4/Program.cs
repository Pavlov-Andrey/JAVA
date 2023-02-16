/*
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int a) {

    int sum = 0;

    for(int current = 1; current <= a; current ++)

        sum += current; 

    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of numbers from 1 to {num} is {s}");
*/


/*
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int DigitCount(int a) {

    int count = 0;

    while(a != 0) {
        a = a / 10;
        count ++;
    }
    return count;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = DigitCount(num);

Console.WriteLine(s);

*/


/*
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int Factorial(int a) {

    int result = 1;
    for(int count = 1; count <= a; count++)
        result *= count;
    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int s = Factorial(num);
Console.WriteLine(s);

*/


/*
// Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue) {

    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] array) {

    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

    Console.WriteLine();
    
}
*/
/*
// Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue) {

    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] array) {

    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

    Console.WriteLine();
    
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
