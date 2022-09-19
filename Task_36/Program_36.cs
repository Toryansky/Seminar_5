// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Одномерный массив, заполненный случайными числами от -100 до 100:");

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
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

int SummarizeElementsOnOddIndex(int[] array)
{
    int summa = 0;
    for (int i = 1; i < arr.Length; i++)
        if (i % 2 == 1)
        {
            summa += arr[i];
        }
    return summa;
}
int result = SummarizeElementsOnOddIndex(arr);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {result}");