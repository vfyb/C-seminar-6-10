// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Поменять массив на обратный без использования второго массива

int[] ReverseArray(int[] arr)
{
    int tmp = 0;
    for ( int i = 0; i < arr.Length / 2; i++)
    {
        tmp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = tmp;
    }
    return arr;
}

int[] array = new int[5] { 1, 2, 3, 4, 5 };
int[] result = ReverseArray(array);

for ( int i = 0; i < 5; i++) Console.Write($"{array[i]}, ");
Console.WriteLine();
for ( int i = 0; i < 5; i++) Console.Write($"{result[i]}, ");

