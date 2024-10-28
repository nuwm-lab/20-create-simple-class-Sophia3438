using System;

namespace ConsoleApplication1
{
    public class Function
    {
        // Поля для коефіцієнтів функції
        private double a, b, c;

        // Конструктор для ініціалізації коефіцієнтів a, b і c
        public Function(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Метод для обчислення значення функції в точці x
        public double Evaluate(double x)
        {
            return -a * x * x + b * x + c;
        }

        // Метод для знаходження точки максимуму
        public double GetMaximumPoint()
        {
            return -b / (2 * a);
        }

        // Метод для перевірки, чи приймає функція найбільше значення в точці x
        public bool IsMaximumAt(double x)
        {
            double maxPoint = GetMaximumPoint(); // Точка максимуму
            double maxValue = Evaluate(maxPoint); // Значення функції в точці максимуму
            double valueAtX = Evaluate(x);        // Значення функції у введеній точці

            // Перевірка, чи значення функції в точці x дорівнює максимальному значенню
            return Math.Abs(valueAtX - maxValue) < 1e-6;
        }
    }

    class TestFunction
    {
        static void Main()
        {
            // Ініціалізація функції з коефіцієнтами a, b, c
            Function function = new Function(1, -4, 3);

            Console.Write("Введіть значення x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // Перевірка, чи функція приймає максимальне значення у введеній точці
            if (function.IsMaximumAt(x))
            {
                Console.WriteLine($"Функція приймає найбільше значення в точці x = {x}.");
            }
            else
            {
                Console.WriteLine($"Функція не приймає найбільше значення в точці x = {x}.");
            }

            // Виведення значення функції у точці x
            double value = function.Evaluate(x);
            Console.WriteLine($"Значення функції в точці x = {x} дорівнює {value}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
