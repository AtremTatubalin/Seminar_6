//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double getUserCoefficient(string massege)
{
    Console.WriteLine(massege);
    double coef = double.Parse(Console.ReadLine()!);
    return coef;
}

double Intersection(double b1, double k1, double b2, double k2)
{
    double result = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Точек пересечения нет.");
    }
    else
    {
        result = (b2 - b1) / (k1 - k2);
    }
    return result;
}

double b1 = getUserCoefficient("Введите b1: ");
double k1 = getUserCoefficient("Введите k1: ");
double b2 = getUserCoefficient("Введите b2: ");
double k2 = getUserCoefficient("Введите k2: ");

double res = Intersection(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения функций х = {res}");