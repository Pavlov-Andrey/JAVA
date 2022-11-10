
/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandom2dArray() {
    Console.Write("Ведите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ведите минимальный диапазон: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите максимальный диапазон: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)  
        for (int j = 0; j < columns; j++) 
            array[i,j] = Math.Round((random.Next(minValue, maxValue) + random.NextDouble()), 1);
    return array;
}
void Print2dArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
double[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandom2Array() {
    Console.Write("Ведите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ведите минимальный диапазон: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите максимальный диапазон: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2Array(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FindElement(int[,] array)
{
    Console.Write("Введите значение элемента строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение элемента столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
        Console.WriteLine($"Элемент с индексами [{i},{j}] = {array[i, j]}");
    else
        Console.WriteLine("Значение элемента не найдено!");
}
int[,] myArray = CreateRandom2Array();
Print2Array(myArray);
FindElement(myArray);
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2Array() {
    Console.Write("Ведите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ведите минимальный диапазон: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите максимальный диапазон: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Print2Array(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] myArray = CreateRandom2Array();
Print2Array(myArray);

double[] Avg(int[,] array) {

    double[] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++) {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newarray[j] = Math.Round((sum / array.GetLength(0)),1);
    }  
    return newarray;
}
void PrintArray(double[] array) {
    Console.Write("Среднее арифметическое столбцов: ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
double[] newarray = Avg(myArray);
PrintArray(newarray);

*/