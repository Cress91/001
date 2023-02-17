// Задайте массив вещественных чисел. Найдите разницу
// между минимальным и максимальным элементами массива.

System.Console.WriteLine("Задайте массив");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
System.Console.WriteLine(String.Join(",", array));

int max = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    max = array[i];
}
int min = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] < min )
    min = array[i];
}
System.Console.WriteLine($"Разница между мин и макс: {max - min}");