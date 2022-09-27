// Задача 59: 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
            resultArray[i, j] = random.Next(0, 5);
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

// Find i and j of minimum element
int[] FindRowColumnMinElement(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                result[0] = i;
                result[1] = j;
                min = array[i, j];
            }
        }
    }
    Console.WriteLine($"i = {result[0]}, j = {result[1]}");
    return result;
}

int[,] DeleteRowColumnInArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] toDelete = FindRowColumnMinElement(array);

    int resultRow = 0;
    int resultColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != toDelete[0] && j != toDelete[1])
            {
                result[resultRow, resultColumn] = array[i, j];
                resultColumn++;
                //Console.WriteLine($"resultColumn = {resultColumn}");
            }
        }
        if (i != toDelete[0]) resultRow++;
        resultColumn = 0;
        //Console.WriteLine($"resultRow = {resultRow}");
    }

    return result;
}

int row = GetAnyIntNumber("rows");
int column = GetAnyIntNumber("columns");

int[,] oldArray = CreateArrayRandomNumbers(row, column);
PrintArrayToConsole(oldArray);

Console.WriteLine();

int[,] newArray = DeleteRowColumnInArray(oldArray);
PrintArrayToConsole(newArray);