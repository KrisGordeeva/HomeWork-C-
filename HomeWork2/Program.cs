//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


/*Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num / 10 % 10;
Console.WriteLine($"Вторая цифра числа {num} это {result}");
*/




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + numText[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
*/




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

bool TheDayOfTheWeek (int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Этот день выходной");
        return true;
    }
    if (1 > num || num > 7)
    {
        Console.WriteLine("Эта цифра не является днем недели");
        return false;
    }
    else 
    {
        Console.WriteLine("Этот день не выходной");
        return false;
    }
}

bool res = TheDayOfTheWeek (num);
*/