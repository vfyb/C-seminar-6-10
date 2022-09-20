// Задача 46: 
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4. 
// 1 4 8 19
// 5 -2 33 -2 
// 77 3 8 1

int[,] CreateArrayRandomNumbers(int row, int column)
{
    var random = new Random();
    int[,] resultArray = new int[row, column];

    for ( int i = 0; i < row; i++)
    {
        for ( int j = 0; j < column; j++)
        {
            resultArray[i,j] = random.Next(-100, 101);
        }
    } 
    return resultArray;
}

// Print array to Console
void PrintArrayToConsole(int[,] array)
{
    // Console.Write($"[ ");
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

Console.Write("Input number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateArrayRandomNumbers(row, column);

PrintArrayToConsole(newArray);


// int row = 0;
// int column = 0;
// Console.Write("Input number of rows: ");
// bool parseIsOk = int.TryParse(Console.ReadLine(), out int number));
// if ( !parseIsOk )
// {
//     Console.WriteLine($"{array[i]} ]");
//     return
// }
// else result = number
