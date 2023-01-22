/* 
Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Пример b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5) */


double b1 = GetNumberFromUserb1();
double k1 = GetNumberFromUserk1();
double b2 = GetNumberFromUserb2();
double k2 = GetNumberFromUserk2();

numbers(b1, k1, b2, k2);

double GetNumberFromUserb1()
{
    while (true)
    {
        Console.Write("Введите число b1: ");
        bool isCorrect = double.TryParse(Console.ReadLine(), out double b1);
        if (isCorrect)
        {
            return b1;
        }
        else Console.Write("Ошибка вода! Попробуйте снова: ");
    }
}
double GetNumberFromUserk1()
{
    while (true)
    {
        Console.Write("Введите число к1: ");
        bool isCorrect = double.TryParse(Console.ReadLine(), out double k1);
        if (isCorrect)
        {
            return k1;
        }
        else Console.Write("Ошибка вода! Попробуйте снова: ");
    }
}
double GetNumberFromUserb2()
{
    while (true)
    {
        while (true)
        {
            Console.Write("Введите число b2: ");
            bool isCorrect = double.TryParse(Console.ReadLine(), out double b2);
            if (isCorrect)
            {
                return b2;
            }
            else Console.Write("Ошибка вода! Попробуйте снова: ");
        }
    }
}
double GetNumberFromUserk2()
{
    while (true)
    {
        Console.Write("Введите число к2: ");
        bool isCorrect = double.TryParse(Console.ReadLine(), out double k2);
        if (isCorrect)
        {
            return k2;
        }
        else Console.Write("Ошибка вода! Попробуйте снова: ");
    }
}


void numbers(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = 0;
        x = (b1 - b2) / (k2 - k1);
        double y = 0;
        y = ((((b1 - b2) / (k2 - k1)) * k1) + b1);
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
    }
    else Console.WriteLine("Прямые параллельны!");
}


