// Bubble sort

bool SearchElem(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return true;
        }
    }
    return false;
}

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    bool flag = false;
    while (flag != true)
    {
        flag = false;

        int temp = new Random().Next(1, 100);
        if (SearchElem(array, temp))
        {
            continue;
        }
        else
        {
            array[i] = temp;
            flag = true;
        }
    }
}