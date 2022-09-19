// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

Console.WriteLine("Массив из вещественных чисел, заполненный случайными числами от 0 до 100:");
double[] arrayRealNumbers = new double[10];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = Math.Round(new Random().NextDouble() * 100, 2); //округление до второго знака
    Console.Write($"{arrayRealNumbers[i]}\t");
}

double maxValueInArray = arrayRealNumbers[0];
double minValueInArray = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxValueInArray < arrayRealNumbers[i])
    {
        maxValueInArray = arrayRealNumbers[i];
    }
    if (minValueInArray > arrayRealNumbers[i])
    {
        minValueInArray = arrayRealNumbers[i];
    }
}
double result = Math.Round(maxValueInArray - minValueInArray, 2);

Console.WriteLine($"\nМаксимальное значение в массиве: {maxValueInArray}");
Console.WriteLine($"Минимальное значение в массиве: {minValueInArray}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {result}");