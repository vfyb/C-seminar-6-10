// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

string ConvertToBinary(int num)
{
    string result = "";

    while ( num > 0 )
    {
        result = Convert.ToString(num % 2) + result;
        num = num / 2;
    } 

    return result;
}

int number = GetAnyNumber("number");
string binaryNumber = ConvertToBinary(number);

Console.WriteLine($"{number} -> {binaryNumber}");
