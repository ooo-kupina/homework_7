// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine($"\nДанная программа выведет двумерный массив, заполненный случайными целыми числами в промежутке между 0 и 100,");
Console.WriteLine("и которая находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine($"\nКоличество строк и столбцов в массиве задаёт пользователь.");

Console.WriteLine($"\nВведите количество строк - целое число меньше 20:");
int row = Convert.ToInt32(Console.ReadLine());
if (row > 20 || row < 1)
{
    Console.Write($"\nУказанное число строк задано некорректно. Программа прервана. Введите целое число от 1 до 20.\n");
    return;
}
Console.WriteLine($"\nВведите количество столбцов - целое число меньше 20:");
int col = Convert.ToInt32(Console.ReadLine());
if (col > 20 || col < 1)
{
    Console.Write($"\nУказанное число столбцов задано некорректно. Программа прервана. Введите целое число от 1 до 20.\n");
    return;
}
Console.WriteLine();

void FillArrayRandomNumbers(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(j < array.GetLength(1) - 1 ? $"{array[i, j],4}," : $"{array[i, j],4} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void Average(double[,] array)
{
    int count = default;
    double sum = default;
    double avr = default;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count = 0;
        sum = 0;
        avr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count++;
            sum += array[i, j];
        }
        avr = Math.Round(sum / count, 2);
        Console.WriteLine($"Среднее арифметическое столбца {j}: {avr}");
    }
}

double[,] numbers = new double[row, col];
FillArrayRandomNumbers(numbers, 0, 100);
PrintArray(numbers);
Console.WriteLine();
Average(numbers);
Console.WriteLine();

