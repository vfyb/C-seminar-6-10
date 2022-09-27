// Задача 55: 
// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.


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
    var random = new Random();
    int[,] resultArray = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

int[,] ChangeRowsAndColumns(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int tmp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}

int row = GetAnyIntNumber("rows");
int column = GetAnyIntNumber("columns");

int[,] oldArray = CreateArrayRandomNumbers(row, column);
PrintArrayToConsole(oldArray);

Console.WriteLine();

if (row == column)
{
    int[,] newArray = ChangeRowsAndColumns(oldArray);
    PrintArrayToConsole(newArray);

    Console.WriteLine();
    PrintArrayToConsole(oldArray);
}
else
{
    Console.WriteLine("Can't cerate array with such parameters.");
}
