// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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
string NaturalNumbers(int num)
{
    string result = string.Empty;

    if (num == 1)
    {
        result = "1";
    }
    else
    {
        result =$"{num}" + ", " + NaturalNumbers(num - 1);
    }
    return result;
}

int number = GetAnyIntNumber("number");
string natNum = string.Empty;

natNum = NaturalNumbers(number);
Console.WriteLine(natNum);
