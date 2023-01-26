Console.WriteLine("Даны 600 чисел");
int[] array = NewArray(600, 0, 1000);
Console.Write($"{String.Join(" ", array)}");
int sum = Summa(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 100 и кратных 3 равно: {sum}");
int[] NewArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

int Summa(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] > 100) & (array[i] % 3 == 0))
            sum = sum + 1;

    }
    return sum;
}