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
double[] GetIntersection(int[,] lines)
{
    // double x = ( b2 - b1 ) / ( k1 - k2 );
    // double y = k1 * x + b1;

    // With array:
    double x = (double)( lines[1, 1] - lines[0, 1] ) / ( lines[0, 0] - lines[1, 0] );
    double y = (double)(lines[0, 0] * x + lines[0, 1]);

    double[] result = new double[] {x, y};
    
    return result;
}

int[,] userLines = GetValuesForLines();
double[] intersectionPoint = GetIntersection(userLines);

Console.WriteLine($"Lines ( y = {userLines[0, 0]}x + {userLines[0, 1]} ) and ( y = {userLines[1, 0]}x + {userLines[1, 1]} )");
Console.WriteLine($"Intersect in point [ {intersectionPoint[0]}, {intersectionPoint[1]} ]");
