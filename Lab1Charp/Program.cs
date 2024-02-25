// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);
    double p = 4 * Math.Sqrt(s);
    Console.WriteLine("p=" + p);

}
Console.WriteLine("Lab 1 !");
task1();
// continue ...


1.6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжину першого катета:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть довжину другого катета:");
        double b = double.Parse(Console.ReadLine());

        double c = CalculateHypotenuse(a, b);
        Console.WriteLine($"Гіпотенуза прямокутного трикутника з катетами {a} і {b} дорівнює {c}");
    }

    static double CalculateHypotenuse(double side1, double side2)
    {
        return Math.Sqrt(side1 * side1 + side2 * side2);
    }
}
2.6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть значення a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть значення b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть значення c:");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            Console.WriteLine("Рівняння має два розв'язки.");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Рівняння має один розв'язок.");
        }
        else
        {
            Console.WriteLine("Рівняння не має розв'язків.");
        }
    }
}
3.6

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть координату x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть координату y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(CheckPoint(x, y));
    }

    static string CheckPoint(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        if (distance < 15)
        {
            return "Ні";
        }
        else if (distance <= 25)
        {
            return "Так";
        }
        else
        {
            return "На межі";
        }
    }
}
4.6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість днів, що пройшли з 1 січня 1990 року:");
        int days = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(1990, 1, 1);
        DateTime targetDate = startDate.AddDays(days);

        string monthName = targetDate.ToString("MMMM");
        Console.WriteLine($"Поточний місяць: {monthName}");
    }
}
5.6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double num2 = double.Parse(Console.ReadLine());

        double difference = CalculateDifference(num1, num2);
        Console.WriteLine($"Різниця між числами: {difference}");
    }

    static double CalculateDifference(double a, double b)
    {
        return a - b;
    }
}
6.6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть значення x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = CalculateExpression(x, y);
        Console.WriteLine($"Відповідь: {result}");
    }

    static double CalculateExpression(double x, double y)
    {
        return x * y + Math.Pow(x + y, 2) + 3 / Math.Pow(x, 2) + 5;
    }
}
