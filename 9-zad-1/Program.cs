// Задача 64: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

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

// Get string with natual numbers
string NaturaleNumbers(int min, int max)
{
    string result = string.Empty;

    if (max == min)
    {
        result = $"{min}";
    }
    else
    {
        result = NaturaleNumbers(min, (max - 1)) + ", " + $"{max}";
    }
    return result;
}

int min = GetAnyIntNumber("minimum number");
int max = GetAnyIntNumber("maximum number");
string natNum = string.Empty;

if (min <= max)
{
    natNum = NaturaleNumbers(min, max);
    Console.WriteLine(natNum);
}
else
{
    natNum = NaturaleNumbers(max, min);
    Console.WriteLine(natNum);
}
