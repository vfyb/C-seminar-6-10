// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// Create array user size with random (from 0 to 99) int elements 
int[,] CreateArrayRandomNumbers(int row, int column)
{
    var random = new Random();
    int[,] resultArray = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultArray[i, j] = random.Next(0, 100);
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

// Find average of elements in columns
void FindAverageOfColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumOfColumn = 0;
        double averageOfColumn = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumOfColumn = sumOfColumn + array[i, j];
        }

        averageOfColumn = sumOfColumn / array.GetLength(0);
        Console.Write($"{averageOfColumn}  ");
    }
}

int row = GetAnyIntNumber("quantitry of rows in array");
int column = GetAnyIntNumber("quantitry of columns in array");

if (row > 0 && column > 0)
{
    int[,] newRandomArray = CreateArrayRandomNumbers(row, column);
    PrintArrayToConsole(newRandomArray);

    Console.WriteLine("Average of columns:");
    FindAverageOfColumns(newRandomArray);
}
else
{
    Console.WriteLine("Can't create array with such parameters.");
}
