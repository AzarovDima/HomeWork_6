/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */



double[] array;
while (true)
{
    try
    {
        Console.Write("Введите элементы(через пробел): ");
        array = Array.ConvertAll((Console.ReadLine() ?? "").Split(), double.Parse);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

double count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количесство элементов > 0: {count}");