// Задача 67: 
// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

int SumDigit(int num)
{
    int sum = 0;
    if (num > 0)
    {
        sum = SumDigit(num / 10) + (num % 10);
    }
    return sum;
}

Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);
