//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("ВВедите числа: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ' ')
        {
            if(i != input.Length - 1)
            {
                temp += input [i].ToString();
            i++;
            }
            else
            {
                temp += input [i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

if(k1 == k2 && b1 < b2 || b1 > b2)
{
    Console.WriteLine("Две прямые параллельны");
}
    else if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Две прямые совпадают");
    }
    else
    {
        Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    } 
*/