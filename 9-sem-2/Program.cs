// Задача 63: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NaturNumbers(int num)
{
    string natNum = "";
    if (num == 1)
    {
        natNum = "1";
    }
    else
    {
        natNum = NaturNumbers(num - 1) + ", " + $"{num}";
    }
    return natNum;
}

int SumNumber(int num)
{
    if (num >= 1)
    {
        num = num + SumNumber(num - 1);
    }
    return num;

}

Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());
string natNumString = NaturNumbers(number);

int sum = SumNumber(number);

Console.WriteLine(number);
Console.WriteLine(natNumString);
Console.WriteLine(sum);
