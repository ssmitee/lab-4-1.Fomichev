int[] array = new int[11];
Console.WriteLine("Введите значения массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0 && array[i] % 2 != 0)
    {
        sum += array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 3 == 0)
    {
        array[i] = sum;
    }
}
Console.WriteLine("\nИзмененный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}