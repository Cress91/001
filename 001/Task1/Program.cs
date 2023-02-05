// Напишите программу, которая принимает на вход
// трехзначное число и показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = (number1 / 10) % 10;

System.Console.WriteLine(number2);
