// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

// Fill  array like snake
int[,] FillSnakeArray(int size)
{
    int[,] array = new int[size, size];
    int i = 0;
    int j = -1;
    int number = 0;

    for (int cycle = 0; cycle < size; cycle = cycle + 2)
    {
        for (int repeat = (size - cycle); repeat > 0; repeat--)
        {
            j++;
            number++;
            array[i, j] = number;
            
        }

        for (int repeat = (size - cycle - 1); repeat > 0; repeat--)
        {
            i++;
            number++;
            array[i, j] = number;
        }

        for (int repeat = (size - cycle - 1); repeat > 0; repeat--)
        {
            j--;
            number++;
            array[i, j] = number;
        }

        for (int repeat = (size - cycle - 2); repeat > 0; repeat--)
        {
            i--;
            number++;
            array[i, j] = number;
        }
    }
    return array;
}

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

int size = GetAnyIntNumber("size of array");

int[,] newArray = FillSnakeArray(size);

PrintArrayToConsole(newArray);
