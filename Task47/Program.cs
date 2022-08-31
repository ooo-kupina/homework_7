// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.WriteLine($"\nДанная программа выведет двумерный массив, заполненный случайными вещественными числами в промежутке между 0 и 100.");
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
double[,] numbers = new double[row, col];

void FillArrayRandomNumbers(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
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
            Console.Write(j < array.GetLength(1) - 1 ? $"{array[i, j],6}," : $"{array[i, j],6} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

FillArrayRandomNumbers(numbers, 0, 100);
PrintArray(numbers);
Console.WriteLine();

