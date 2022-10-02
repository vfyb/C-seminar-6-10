// Задача 68: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

// Get result of Akkerman function
int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if ((m != 0) && (n == 0))
        {
            return GetAkkerman(m - 1, 1);
        }
        else
        {
            return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
        }
    }
}

int m = GetAnyIntNumber("m");
int n = GetAnyIntNumber("n");

if (m >= 0 && n >= 0)
    Console.WriteLine($"A(m, n) = {GetAkkerman(m, n)}");
