using System;

class Program
{
    static void Main()
    {
        // Ввод длины катетов
        Console.Write("Введите длину первого катета: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите длину второго катета: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Вычисление гипотенузы по теореме Пифагора
        double c = Math.Sqrt(a * a + b * b);

        // Вычисление площади треугольника
        double area = 0.5 * a * b;

        // Вычисление периметра треугольника
        double perimeter = a + b + c;

        // Вывод результатов
        Console.WriteLine($"Площадь треугольника: {area:F2} кв. ед.");
        Console.WriteLine($"Периметр треугольника: {perimeter:F2} ед.");
    }
}
