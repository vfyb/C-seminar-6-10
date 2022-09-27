// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Create array with random int elements
int[,] CreateArrayRandomNumbers(int row, int column)
{
    Random random = new Random();
    int[,] resultArray = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultArray[i, j] = random.Next(0, 10);
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

// Get row with index from array[,]
int[] GetRowFromArray(int[,] array, int row)
{
    int[] rowArray = new int[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowArray[j] = array[row, j];
    }
    return rowArray;
}

// Get minimal sum row
void GetRowMinimalSumOfElements(int[,] array)
{
    int[] rowArray = GetRowFromArray(array, 0);

    int minRowSum = rowArray.Sum();
    int rowResultIndex = 1;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        rowArray = GetRowFromArray(array, i);

        if (rowArray.Sum() < minRowSum)
        {
            minRowSum = rowArray.Sum();
            rowResultIndex = i + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Row with minimal sum of elements: {rowResultIndex}");
    Console.WriteLine($"Sum of elements in this row: {minRowSum}");
}

int row = GetAnyIntNumber("rows");
int column = GetAnyIntNumber("columns");

int[,] newArray = CreateArrayRandomNumbers(row, column);

PrintArrayToConsole(newArray);
GetRowMinimalSumOfElements(newArray);
