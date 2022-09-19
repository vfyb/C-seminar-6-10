// Задача 40:
// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

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

int[] GetTriangleArray()
{
    int[] result = new int[3];

    for (int i = 0; i < 3; i++)
    {
        result[i] = GetAnyNumber($"length of the {i+1} side of the triangle");
    }
    return result;
}

bool CheckAbilityOfTriangle(int[] array)
{
    bool result = false;
    
    int maxIndex = 0;
    for (int i = 0; i < 3; i++)
    {
        if (array[i] > array[maxIndex]) maxIndex = i;
    }

    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        if ( i != maxIndex ) sum = sum + array[i];
    }
    
    if ( sum > array[maxIndex] ) result = true;

    return result;
}

int[] triangleArray = GetTriangleArray();
bool checkAbility = CheckAbilityOfTriangle(triangleArray);

Console.WriteLine($"Triangle: {checkAbility}");
