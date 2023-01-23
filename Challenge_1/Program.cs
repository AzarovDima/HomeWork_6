/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

   

Console.Write("Введите элементы(через пробел): ");

double[] array = Array.ConvertAll((Console.ReadLine() ?? "").Split(), double.Parse);
double count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количесство элементов > 0: {count}");
