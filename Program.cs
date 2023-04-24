// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Задача 19");
Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine ();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - палиндром.");
    }
    else Console.WriteLine($"Число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");

Console.WriteLine("Введите X первой точки ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y первой точки ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z первой точки ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y второй точки ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z второй точки ");
int Z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Длина отрезка {Math.Round(Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)),2)}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов от 1 до {N}");
for (int i=1;i<=N;i++)
{
int kube = (int)Math.Pow(i,3);
Console.WriteLine($"{kube}, ");
}
