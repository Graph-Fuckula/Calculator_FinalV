using Lesson7;
using static System.Runtime.InteropServices.JavaScript.JSType;

var clsMath = new Lesson7.Math();
var clsArray = new Lesson7.GUIConsolApp();
    while (true)
    {
        Console.WriteLine("Введите функцию (count, max, min, factorial, +, -, *, /, %):");
        string oper = Console.ReadLine();
        if (oper == "count" || oper == "max" || oper == "min" || oper == "+" || oper == "*")
    {
        Console.WriteLine("Введите количество и значения элементов:");
        double[] array = { };
        array = clsArray.GetArray(array);
        if (oper == "+")
        {
            Console.WriteLine($"Результат суммирования: {clsMath.Sum(array)}");

        }
        else if  (oper == "count")
        {
            Console.WriteLine($"Длинна вашего массива: {clsMath.Count(array)}");
        }
    else if (oper == "*")
    {
        Console.WriteLine($"Результат умножения: {clsMath.Multiply(array)}");
    }
    else if (oper == "max")
        {
            Console.WriteLine($"Максимальный элемент вашего массива: {clsMath.Max(array)}");
        }
        else if (oper == "min")
        {
            Console.WriteLine($"Минимальный элемент вашего массива: {clsMath.Min(array)}");
        }

        if (oper == "exit")
        {
            break;
        }
}
    else if (oper == "-" || oper == "/ "|| oper == "%")
    {
        Console.WriteLine("Число 1:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Число 2:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        if (oper == "-")
        {
            Console.WriteLine($"Результат вычитания: {clsMath.Minus(num1, num2)}");

        }
         else if (oper == "/")
        {
            Console.WriteLine($"Результат деления: {clsMath.division(num1, num2)}");

        }
        else if (oper == "%")
        {
            Console.WriteLine($"Процент: {clsMath.percent(num1, num2)}");

        }
    }
    else if (oper == "factorial")
    {
        Console.WriteLine("Число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"факториал числа: {clsMath.factorial(num1)}");
    }
    else
    {
        Console.WriteLine("Введите оператор из списка!");
    }

}
