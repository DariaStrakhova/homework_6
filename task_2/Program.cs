/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double Numbers(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

(double, double) ValuePoint(double b1, double k1, double b2, double k2)
{
    double x;
    double y;
    
    x = (b2-b1)/(k1-k2);
    y = k1*x+b1;

    return (x, y);
}

double B1 = Numbers("Введите значение b1: ");
double K1 = Numbers("Введите значение k1: ");
double B2 = Numbers("Введите значение b2: ");
double K2 = Numbers("Введите значение k2: ");

(double X, double Y)= ValuePoint(B1, K1, B2, K2); 
Console.WriteLine($"Координаты точки пересечения({X}; {Y})");