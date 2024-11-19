using System;

public class SinFunction
{
    private double a; // коефіцієнт a
    private double b; // коефіцієнт b

    // Конструктор класу
    public SinFunction(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    // Метод для обчислення значення функції sin(ax + b) в точці x
    public double Evaluate(double x)
    {
        return Math.Sin(a * x + b);
    }

    // Метод для перевірки, чи є точка x максимальною
    public bool IsMaximum(double x)
    {
        // Обчислюємо значення функції в точці x
        double valueAtX = Evaluate(x);

        // Перевіряємо, чи функція має більше значення, ніж в сусідніх точках
        double delta = 0.0001; // мале зміщення для порівняння

        double valueAtXPlusDelta = Evaluate(x + delta);
        double valueAtXMinusDelta = Evaluate(x - delta);

        // Якщо значення в точці x більше за значення в сусідніх точках, то x - максимум
        if (valueAtX > valueAtXPlusDelta && valueAtX > valueAtXMinusDelta)
        {
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        // Введення коефіцієнтів a і b
        Console.WriteLine("Введіть коефіцієнт a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть коефіцієнт b:");
        double b = Convert.ToDouble(Console.ReadLine());

        // Введення точки x
        Console.WriteLine("Введіть точку x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Створення об'єкта функції
        SinFunction sinFunction = new SinFunction(a, b);

        // Перевірка, чи приймає функція найбільше значення в точці x
        if (sinFunction.IsMaximum(x))
        {
            Console.WriteLine($"Функція sin({a}x + {b}) має найбільше значення в точці x = {x}.");
        }
        else
        {
            Console.WriteLine($"Функція sin({a}x + {b}) не має найбільше значення в точці x = {x}.");
        }
    }
}
