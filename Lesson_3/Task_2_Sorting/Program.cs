
int[] arr = { 234, 68, 4, 3, 3, 26, 42, 7, 9, 8, 4, 3, 5, 1234, 123, 12, 123 };
int[] arr1 = new int[arr.Length];
arr.CopyTo(arr1, 0);


void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        PrintArray(array);
        //Console.ReadKey();
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int maxPosition = i;
        for (int j = i; j >= 0; j--)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
        PrintArray(array);
        //Console.ReadKey();
    }
}




PrintArray(arr);

System.Console.WriteLine("--------------------------");

SelectionSortMin(arr);
PrintArray(arr);


System.Console.WriteLine("--------------------------");
System.Console.WriteLine();
System.Console.WriteLine("--------------------------");

PrintArray(arr1);

System.Console.WriteLine("--------------------------");
SelectionSortMax(arr1);
PrintArray(arr1);
