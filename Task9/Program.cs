// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечетных позициях.

System.Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int[] array = GetArray(size);

int[] array (int size)
{
   int[] array = new int[size];

   for (int i = 0; i < size; i++)
   {
       array[i] = new Random().Next(-100, 100);
       int element = array[i];
       if (i % 2 != 0)
       {
        sum = sum + element;
       }
   }
   return array;
}
System.Console.WriteLine(String.Join(",", array));
System.Console.WriteLine($"Sum of elements of odd numbers: {sum}");