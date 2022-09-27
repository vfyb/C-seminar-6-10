// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Sort with Array.Sort method
int[,] SortRowElementMaxToMin(int[,] array)
{
    int[] rowArray = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Extract row from array
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[i, j];
        }

        // Sort row from max to min
        Array.Sort(rowArray, (x, y) => y.CompareTo(x));

        // Insert row to array
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rowArray[j];
        }

    }
    return array;
}

int row = GetAnyIntNumber("rows");
int column = GetAnyIntNumber("columns");

Console.WriteLine("Old array:");
int[,] oldArray = CreateArrayRandomNumbers(row, column);
PrintArrayToConsole(oldArray);

Console.WriteLine("New array:");
int[,] newArray = SortRowElementMaxToMin(oldArray);
PrintArrayToConsole(newArray);
