//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}

ShowNumbers(6);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void NumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Sum of elements: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}


Console.Write("Inpit a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpit a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
NumberSum(m, n, 0);
*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
Console.Write("Inpit a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpit a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

Console.WriteLine(AckermanFunction(m, n));
*/
