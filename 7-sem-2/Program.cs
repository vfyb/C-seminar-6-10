// Задача 48: 
// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
//  m = 3, n = 4. 
// 0 1 23
// 1 2 34
// 2 3 45


// int[,] CreateArrayRandomNumbers(int row, int column)
// {
//     var random = new Random();
//     int[,] resultArray = new int[row, column];

//     for ( int i = 0; i < row; i++)
//     {
//         for ( int j = 0; j < column; j++)
//         {
//             if ( i % 2 == 0 && j % 2 == 0)
//             {
//                 resultArray[i,j] = (int)(Math.Pow(random.Next(-100, 101), 2));
//             }
//             else
//             {
//                 resultArray[i,j] = random.Next(-100, 101);
//             }
            
//         }
//     } 
//     return resultArray;
// }

int[,] CreateArrayRandomNumbers(int row, int column)
{
    var random = new Random();
    int[,] resultArray = new int[row, column];

    for ( int i = 0; i < row; i++)
    {
        for ( int j = 0; j < column; j++)
        {
            resultArray[i,j] = random.Next(0, 50);
        }
    } 
    return resultArray;
}

int SumElementDiagonal(int[,] array)
{
    int sum = 0;
    int min = array.GetLength(0);
    int col = array.GetLength(1);

    if ( col < min ) min = col;

    for ( int i = 0; i < min; i++)
    {
        sum = sum + array[i, i];
    } 
    return sum;
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
int sumArray = SumElementDiagonal(newArray);

PrintArrayToConsole(newArray);
Console.WriteLine($"{sumArray}");


