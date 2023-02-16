// Урок 5. Функции продолжение 

/*

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
int EvenNumbers(int[]array) {
    int amount = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0)
            amount++;
            
    }
    return amount;
}

Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int[] myArray = CreateRandomArray(size, minValue, maxValue);
int result = EvenNumbers(myArray);
ShowArray(myArray);
Console.WriteLine($"ответ: {result}");

*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue) {
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
} 
void ShowArray(int[] array) {
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
     Console.WriteLine();
}
int SumOfNegativesPosision(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] % 2 != 0)
            sum += array[i];
    }
    return sum;
}
Console.Write("Задайте одномерный массив: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный диапазон чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный диапазон чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
int result = SumOfNegativesPosision(myArray);
ShowArray(myArray);
Console.WriteLine("Сумма элементов на нечетных позициях равна: " + result);



/*

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int DiffMinMaxNumbers(int[] array) {
    int min = array[0];
    int max = array[0]; 
    int num = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
        num = max - min;
    }
    return num;
}

Console.Write("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный диапазон элементов массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный диапазон элементов массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, minValue, maxValue);
ShowArray(myArray);

int result = DiffMinMaxNumbers(myArray);
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + result);

*/