//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Inpit a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void SearchElement(int a, int b, int[,] array)
{
    if (array.GetLength(0) > a && array.GetLength(1) > b && a >= 0 && b >= 0)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == a && j == b) Console.WriteLine("Search element: " + array[i, j]);
            }
        }
    }
    else Console.WriteLine("This element does not exist");
}


Console.Write("Inpit a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpit a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a index of row: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpit a index of column: ");
int b = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
SearchElement(a, b, array);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Random rnd = new Random();
int[,] array = new int[rnd.Next(1, 10), rnd.Next(1, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + "");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{sum / array.GetLength(0)} ");
}
Console.ReadLine();
*/
