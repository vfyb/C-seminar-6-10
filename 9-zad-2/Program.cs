// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

// Get sum of natural numbers from M to N
int SumNaturalNumbers(int min, int max)
{
    int result = min;

    if (max == min)
    {
        result = min;
    }
    else
    {
        result = SumNaturalNumbers((min + 1), max) + result;
    }
    return result;
}

int min = GetAnyIntNumber("minimum number");
int max = GetAnyIntNumber("maximum number");
int sumNatNum = 0;

if (min <= max)
{
    sumNatNum = SumNaturalNumbers(min, max);
    Console.WriteLine(sumNatNum);
}
else
{
    sumNatNum = SumNaturalNumbers(max, min);
    Console.WriteLine(sumNatNum);
}
