


int number = int.Parse(Console.ReadLine());

int Funk(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum = number %10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine(Funk(number));
