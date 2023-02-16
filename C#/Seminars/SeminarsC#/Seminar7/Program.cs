//# Двумерные массивы

/*
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int [,] CreateRandom2dArray() {

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
            array[i,j] = new Random().Next(minValue, maxValue +1);

    return array;
}

void Show2dArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {

        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();

    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

/*
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int [,] Create2dArray() {

    Console.Write("Ведите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
    
        for (int j = 0; j < columns; j++) 
            array[i,j] = i + j;

    return array;
}

void Show2dArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {

        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();

    }
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
*/

/*

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int [,] CreateRandom2dArray() {

    Console.Write("Ведите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите минимальный диапазон: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите максимальный диапазон: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i+=2) 
    
        for (int j = 0; j < columns; j+=2) 
            array[i,j] = new Random().Next(minValue, maxValue +1);
                       
    return array;
}
void Show2dArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {

        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();

    }
}

void Quard2dArray(int[,] array) {

    for(int i = 0; i < array.GetLength(0); i += 2) {

        for(int j = 0; i < array.GetLength(1); j += 2)
            array[i,j] = array[i,j] * array[i,j];

        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Quard2dArray(myArray);
Show2dArray(myArray);

*/


/*

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int [,] CreateRandom2dArray() {

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
            array[i,j] = new Random().Next(minValue, maxValue +1);

    return array;
}

void Show2dArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {

        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();

    }
}

int SumOfDiagonalElements(int[,] array) {

    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(0); i++)
        sum = sum = array[i,i];
        return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int sum = SumOfDiagonalElements(myArray);
Console.WriteLine(sum);

*/
