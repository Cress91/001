// Напишите программу, которая принимает
// число и выдает сумму цифр в числе.

System.Console.WriteLine((Введите число));
int num = int.Parse(Console.ReadLine());

int  Func(int num)
{
    int sum = 0;
    while(num > 0)
    {
       sum = sum + num % 10
       num = num / 10
    
       }   return sum;

}
System.Console.WriteLine(Func((num)));