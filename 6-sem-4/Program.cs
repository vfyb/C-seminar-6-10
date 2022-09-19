// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

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

void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for ( int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1 ) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]} ]");
    }
}

int[] Fibonacci(int num)
{
    int[] result = new int[num];

    if ( num < 1 ) Console.WriteLine("Can't show Fibonacci series");
    if ( num == 1 ) result = new[] {0};
    if ( num == 2 ) result = new[] {0, 1};

    if ( num > 2 )
    {
        result[0] = 0;
        result[1] = 1;
        for ( int i = 2; i < num; i++)
        {
            result[i] = result[i-2] + result[i-1];
        }
    }

    return result;
}

int number = GetAnyNumber("number");
int[] arrayFibonacci = Fibonacci(number);

PrintArray(arrayFibonacci);
