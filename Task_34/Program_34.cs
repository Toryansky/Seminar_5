// Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Массив, заполненный случайными положительными трёхзначными числами:");

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}
int[] arr = CreateArray();
PrintArray(arr);

int CountEvenNumbers(int[] array)
{
    int quantityEvenNumbers = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
        {
            quantityEvenNumbers++;
        }
    return quantityEvenNumbers;
}
int quantityEvenNumbers = CountEvenNumbers(arr);
Console.WriteLine($"\nКоличество чётных чисел в массиве: {quantityEvenNumbers}");