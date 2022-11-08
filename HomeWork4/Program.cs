//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int degree(int a, int b)
{
    int result = 1;
    {
        for(int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        return result;
    }
}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int deg = degree(a, b);
Console.WriteLine($"Ответ: {deg}");

*/



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int Digits(int number)
{
   int dig = 0;
   while(number != 0)
   {
        int i = number % 10;
        number = number / 10;
        dig = dig + i;
   }
   return dig;
}

Console.WriteLine("Ведите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр: {Digits(a)}");
*/