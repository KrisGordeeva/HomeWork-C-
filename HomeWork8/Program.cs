//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
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

int[,] myArray = CreateRandom2dArray(m, n, min, max);

Show2dArray(myArray);
SortArrayLines(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void RowMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"The row with the smallest sum of elements: {minSumRow + 1}");
}


Console.Write("Inpit a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m, n, min, max);

Show2dArray(myArray);
Console.WriteLine();
RowMinSum(myArray);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int numX = 2;
int numY = 2;
int numZ = 2;
int minNum = 10;
int maxNum = 99;
int[,,] array = new int[numX, numY, numZ];

FillArrayRandomNumber(array, minNum, maxNum);
PrintArray(array);

void FillArrayRandomNumber(int[,,] array, int minNum = 0, int maxNum = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = rand.Next(minNum, maxNum + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) 
                return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2}) ", i, j, k);
            }
            Console.WriteLine();
        }
    }
}
*/
