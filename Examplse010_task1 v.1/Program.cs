void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + ", ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

System.Console.Write("Позицию какого числа найти? Введите число=>");
int find = int.Parse(Console.ReadLine());
System.Console.WriteLine();
int pos = IndexOf(array, find);
System.Console.WriteLine(pos + 1);