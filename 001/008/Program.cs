// Напишите программу, которая выводит массив 
// из 8 эл-тов и выводит их на экран

PrintArray(GetRandomArray(8));

int[] GetRandomArray(int legth)
{
    int[] result = new int[legth];

    for (int i = 0; i < legth; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.WriteLine(item);
    }
}

