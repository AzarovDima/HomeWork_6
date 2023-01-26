
int[] array;
while (true)
{
    try
    {
        Console.Write("Введите шесть целых чисел (через пробел): ");
        array = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((array[i] < 0) & (array[i] % 5 == 0) & (i < 6))
    {
        count++;
    }
}
Console.WriteLine($"Количесство отрицательных чисел кратных 5 равно: {count}");