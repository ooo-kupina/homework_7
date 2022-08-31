// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine($"\nДанная программа выведет двумерный массив, заполненный случайными целыми числами в промежутке между 0 и 100,");
Console.WriteLine("которая на вход принимает позиции элемента в этом массиве и");
Console.WriteLine("возвращает значение этого элемента или же указание, что такого элемента нет.");
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

void FillArrayRandomNumbers(int[,] array, int min, int max)
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(j < array.GetLength(1) - 1 ? $"{array[i, j],3}," : $"{array[i, j],3} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void Position(int[,] array, int x, int y)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        Console.WriteLine($"Число на позиции с индексами {x}, {y}: {array[x, y]}");
    }
    else 
    {
        Console.WriteLine($"Такого числа нет");
    }
}

int [,] numbers = new int [row, col];
FillArrayRandomNumbers(numbers, 0, 100);
PrintArray(numbers);
Console.WriteLine($"\nВведите индексы вашего числа.\n");
Console.Write("Индекс по строке: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс по столбцу: ");
int col2 = Convert.ToInt32(Console.ReadLine());
Position(numbers, row2, col2);
Console.WriteLine();
