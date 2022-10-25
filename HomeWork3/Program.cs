//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int leng = num.Length;

if (leng == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Число {num} не является пятизначным");
}
*/




//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;

}

Console.WriteLine("Введите координаты первой точки по оси x: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси z: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси x: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси y: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси z: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками {res}");
*/




//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void cube(int n)
{
    int i = 1;
    while(i <= n)
    {
        int result =i * i * i;
        Console.Write(result + " ");
        i++;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
cube(n);
*/