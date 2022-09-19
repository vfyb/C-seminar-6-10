// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int? GetAnyNumber(string text)
{
    Console.WriteLine($"Input {text}: ");
    
    while (true)
    {
        try
        {
            int? result = null;
            string? inputText = Console.ReadLine();

            if ( inputText != "" )
            {
                result = Convert.ToInt32(inputText);
                return result;
            }
            else return result;          
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

int[] GetArrayWithUserNumbers()
{
    int[] array = new int[0];
    Console.WriteLine("Input numbers OR press 'Enter' only to finish");
    
    int index = 0;
    int? inputNumber = 0;

    while ( inputNumber != null )
    {
        inputNumber = GetAnyNumber($"{index + 1} number");
    
        if ( inputNumber != null )
        {
            Array.Resize(ref array, array.Length + 1);
            array[index] = Convert.ToInt32(inputNumber);
        }
        index++;
    }
    return array;
} 

int CountNumbersBiggerZero(int[] array)
{
    int result = 0;

    for ( int i = 0; i < array.Length; i++)
    {
        if ( array[i] > 0 ) result++;
    }
    return result;
}

int[] arrayNumbers = GetArrayWithUserNumbers();
int countNumbersBiggerZero = CountNumbersBiggerZero(arrayNumbers);

PrintArray(arrayNumbers);
Console.WriteLine($"Numbers bigger then Zero: {countNumbersBiggerZero}");
