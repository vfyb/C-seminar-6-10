// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

int PowerNumber(int numA, int numB)
{
    if (numB == 1)
    {
        return numA;
    }
    else
    {
        return numA * PowerNumber(numA, numB - 1);
    }
}

Console.WriteLine("Input number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int powerAB = PowerNumber(numberA, numberB);
Console.WriteLine(powerAB);