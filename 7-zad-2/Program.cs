// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Get int number from user
int GetAnyIntNumber(string text)
{
    Console.WriteLine($"Input {text}: ");

    while (true)
    {
        try
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        catch
        {
            Console.WriteLine("No number was entered. Try again:");
        }
    }
}

// Create array with random (from 10 to 99) int elements with 7 rows and 7 columns
int[,] CreateArrayRandomNumbers()
{
    var random = new Random();
    int[,] resultArray = new int[7, 7];

    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            resultArray[i, j] = random.Next(10, 100);
        }
    }
    return resultArray;
}

// Print array to Console
void PrintArrayToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

// Show element in array with user row and column if possible
void ShowElementInArray(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1))
    {
        PrintArrayToConsole(array);
        Console.WriteLine();
        Console.WriteLine($"Element in array [{row}, {column}] is: {array[row, column]}.");
    }
    else
    {
        PrintArrayToConsole(array);
        Console.WriteLine();
        Console.WriteLine($"There is no element [{row}, {column}] array.");
    }
}

int[,] newRandomArray = CreateArrayRandomNumbers();

int row = GetAnyIntNumber("the row of element");
int column = GetAnyIntNumber("the columns of element");

ShowElementInArray(newRandomArray, row, column);
