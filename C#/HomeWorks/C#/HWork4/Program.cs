// Урок 4. Функции продолжение

/*

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Number(int a, int b) {

    int result = 1;
    for(int i = 0; i < b; i++)
        result *= a;
    return result;
}

Console.Write("Введите число 'А': ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 'B': ");
int numB = Convert.ToInt32(Console.ReadLine());

int ex = Number(numA, numB);

Console.WriteLine($"Число 'А' = {numA} в степени числа 'В' = {numB} равно: {ex}");

*/


/*

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int a) {
   
    int sum = 0;

    while (a > 0) {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = GetSum(num);

Console.WriteLine($"Сумма чисел равна: {sum}");

*/




// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size, int minValue, int maxValue) {

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

Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный диапазон чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный диапазон чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, minValue, maxValue);
ShowArray(myArray);

