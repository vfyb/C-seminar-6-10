// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            resultArray[i, j] = random.Next(0, 4);
        }
    }
    return resultArray;
}

// Multyply two matrix
int[,] GetMultyplyTwoMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = ExtractMultiplyRowColumn(array1, array2, i, j);
        }
    }
    return resultArray;
}

// Extract i row in Array1 b l column in Array2
int ExtractMultiplyRowColumn(int[,] array1, int[,] array2, int row, int column)
{
    int[] rowArray = new int[array1.GetLength(1)];
    int[] columnArray = new int[array2.GetLength(0)];
    int result = 0;

    // Extract row from array1 and column from array2
    for (int i = 0; i < rowArray.Length; i++)
    {
        rowArray[i] = array1[row, i];
        columnArray[i] = array2[i, column];
    }

    // Multiply extracted row to column
    for (int i = 0; i < rowArray.Length; i++)
    {
        result = result + rowArray[i] * columnArray[i];
    }
    return result;
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


int row1 = GetAnyIntNumber("rows of first matrix");
int column1 = GetAnyIntNumber("columns of first matrix");

int row2 = GetAnyIntNumber("rows of second matrix");
int column2 = GetAnyIntNumber("columns of second matrix");

int[,] array1 = CreateArrayRandomNumbers(row1, column1);
int[,] array2 = CreateArrayRandomNumbers(row2, column2);

PrintArrayToConsole(array1);
Console.WriteLine();
PrintArrayToConsole(array2);
Console.WriteLine();

// Check that quantity of columns in array1 == quantity of rows in array2
if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] resultArray = GetMultyplyTwoMatrix(array1, array2);
    PrintArrayToConsole(resultArray);
}
else
{
    Console.WriteLine("Can't multiply this two matrix");
}
