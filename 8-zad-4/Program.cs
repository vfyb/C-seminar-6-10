// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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

// Check number in array or not
bool CheckNumberInArray(int[,,] array, int temp)
{
    bool result = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == temp)
                {
                    result = true;
                    return result;
                }
            }
        }
    }
    return result;
}

// Create 3D array with random non-repeating two-digit numbers
int[,,] CreateArrayRandomNumbers(int row, int col, int dep)
{
    Random random = new Random();
    int[,,] resultArray = new int[row, col, dep];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                bool flag = false;
                while (flag != true)
                {
                    int temp = random.Next(10, 100);
                    if (CheckNumberInArray(resultArray, temp) == false)
                    {
                        resultArray[i, j, k] = temp;
                        flag = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
    return resultArray;
}

// Print array to Console by rows with element's index
void PrintArrayToConsole(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int row = GetAnyIntNumber("row");
int col = GetAnyIntNumber("column");
int dep = GetAnyIntNumber("depth");

if (row * col * dep > 90)
{
    Console.WriteLine("Can't create array with such parameters and non-repeating two-digit numbers");
}
else
{
    int[,,] newArray = CreateArrayRandomNumbers(row, col, dep);
    PrintArrayToConsole(newArray);
}
