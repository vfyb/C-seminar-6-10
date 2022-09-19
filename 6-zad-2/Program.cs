// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

// Get two-dimensional array for two lines
int[,] GetValuesForLines()
{
    int[,] lines = new int[2, 2];
    string[,] linesChar = { {"k1", "b1"}, {"k2", "b2"} };

    for ( int i = 0; i < 2; i++ )
    {
        for ( int j = 0; j < 2; j++ )
        {
            lines[i, j] = GetAnyNumber($"value {linesChar[i,j]} for line {i + 1}");
        }
    }
    return lines;
}

// Get array with intersection point coordinates
void GetIntersection(int[,] lines)
{
    if ( lines[0, 0] == lines[1, 0] )
    {
        if ( lines[0, 1] == lines[1, 1] )
        {
            Console.WriteLine("This lines are the same.");
        }
        else
        {
            Console.WriteLine("There is no intersection of this line.");
        }
    }
    else
    {
        double x = (double)( lines[1, 1] - lines[0, 1] ) / ( lines[0, 0] - lines[1, 0] );
        double y = (double)(lines[0, 0] * x + lines[0, 1]);

        Console.WriteLine($"Lines ( y = {lines[0, 0]}x + {lines[0, 1]} ) and ( y = {lines[1, 0]}x + {lines[1, 1]} )");
        Console.WriteLine($"Intersect in point [ {x}, {y} ]");
    }
}

int[,] userLines = GetValuesForLines();
GetIntersection(userLines);
