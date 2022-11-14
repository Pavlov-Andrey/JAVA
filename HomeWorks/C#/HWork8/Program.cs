/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*

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
int[,] SortMas(int[,] row) {

        for (int i = 0; i < row.GetLength(0); i++) {
            for (int j = 0; j < row.GetLength(1); j++) {  
                for (int x = j + 1; x < row.GetLength(1); x++){
                if (row[i,x] > row[i,j]) {
                    int temp = row[i,x];
                    row[i,x] = row[i,j];
                    row[i,j] = temp;
                }  
            }
        }
    } 
    return row; 
}        
int[,] myArray = CreateRandom2Array();
Print2Array(myArray);
int[,] sortMas = SortMas(myArray);
Print2Array(sortMas);

*/


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
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

int[] minSum(int[,] array) {

    int[] newarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i,j];
        newarray[i] = sum;
        sum = 0;
    }  
    return newarray;
}
void PrintArray(int[] array) {
    Console.Write("Суммы элементов в строках: ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
void MinRow(int[] array) {
    int min = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] < array[min])
            min = i;
    }
    Console.Write($"Строка с наименьшей суммой элементов: {min + 1}");          
    Console.WriteLine(" ");   
}
int[] newarray = minSum(myArray);
PrintArray(newarray);
MinRow(newarray);
*/


/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int [] CreateTwoNum3Array() {
    int[] array = Enumerable.Range(10, 90).ToArray();
    for (int i = 0; i < array.Length; i++) {
        int j = new Random().Next(10, 90);

        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}
int[,,] CubeArray(int[] array, int lenght, int height, int width) {
    int a = 0;
    int[,,] cube = new int[lenght, height, width];
    for (int x = 0; x < lenght; x++) {
        for (int y = 0; y < height; y++) {
            for (int z = 0; z < width; z++) {
            cube[x,y,z] = array[a];
            a++;
            }
        }
    }
    return cube;
}
void Print2Array(int[,,] cube) {
    for (int x = 0; x < cube.GetLength(0); x++) {
        for (int y = 0; y < cube.GetLength(1); y++) {
            for (int z = 0; z < cube.GetLength(2); z++) {
            Console.Write(cube[x,y,z] + " ");
            Console.Write($"({x},{y},{z}) ");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
    }
}

int lenght = 2;
int height = 2;
int width = 2;

int[] myArray = CreateTwoNum3Array();
int[,,] cubeArray = CubeArray(myArray, lenght, height, width);
Print2Array(cubeArray);
*/


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
int[,] ArraySpiral(int rows, int columns) {
    int[,] array = new int[rows, columns];
    for (int pass = 0, current = 1; current <= rows * columns; pass++) {
        for (int i = pass, j = pass; j < columns - pass; j++) {
            array[i,j] = current;
            current++;
        }
        if(current > rows * columns) {
            break;
        }
        for (int i = pass + 1, j = columns - pass - 1; i < rows - pass; i++) {
            array[i,j] = current;
            current++;
        }
        if(current > rows * columns) {
            break;
        }
        for (int i = rows - pass - 1, j = columns - pass - 2; j >= pass; j--) {
            array[i,j] = current;
            current++;
        }
        if(current > rows * columns) {
            break;
        }
        for (int i = rows - pass - 2, j = pass; i > pass; i--) {
            array[i,j] = current;
            current++;
        }
    }
    return array;
}
void PrintArraySpiral(int[,] array, int zeroNum = 2) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j].ToString($"D{zeroNum}") + " "); // "D" регулярное выражение, соответствует любому символу, не являющемуся десятичной цифрой #01, 02, 03...
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = ArraySpiral(rows, columns);
PrintArraySpiral(myArray);
*/