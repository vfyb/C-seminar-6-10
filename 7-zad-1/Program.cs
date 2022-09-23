// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Get int number from user
int GetAnyNumber(string text)
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

// Create array with random double elements
double[,] CreateArrayRandomNumbers(int row, int column)
{
    Random randomDouble = new Random();
    var randomInt = new Random();
    double[,] resultArray = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultArray[i, j] = randomDouble.NextDouble()
                              * randomInt.Next(-100, 101);
        }
    }
    return resultArray;
}

// Print array to Console
void PrintArrayToConsole(double[,] array)
{
    // Console.Write($"[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int row = GetAnyNumber("quantuty of rows");
int column = GetAnyNumber("quantuty of columns");

if (row > 0 && column > 0)
{
    double[,] newArrayRandomNumbers = CreateArrayRandomNumbers(row, column);
    PrintArrayToConsole(newArrayRandomNumbers);
}
else
{
    Console.WriteLine("Can't create array with such parameters.");
}
