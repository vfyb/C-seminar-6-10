// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 
// 0, 2, 8, 
// 0, 9, 9 }
// 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 
// 8 встречается 1 раз 9 встречается 4 раза

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

string[] QuantityArray(int[,] array)
{
    List<int> numbersOfArray = new List<int> { array[0, 0] };

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!numbersOfArray.Contains(array[i, j]))
            {
                numbersOfArray.Add(array[i, j]);
            }
        }
    }

    int[] numbersArray = numbersOfArray.ToArray<int>();
    string[] result = new string[numbersArray.Length];

    for (int index = 0; index < result.Length; index++)
    {
        // Count to zero for next number
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == numbersArray[index])
                {
                    count++;
                }
            }
        }
        result[index] = numbersArray[index] + " встречается " + count + " раз";
    }

    return result;
}

int row = GetAnyIntNumber("rows");
int column = GetAnyIntNumber("columns");

int[,] newArray = CreateArrayRandomNumbers(row, column);
PrintArrayToConsole(newArray);

Console.WriteLine();

string[] quantityArray = QuantityArray(newArray);

for (int i = 0; i < quantityArray.Length; i++)
{
    Console.WriteLine($"{quantityArray[i]}");
}
