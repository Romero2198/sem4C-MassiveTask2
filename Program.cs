Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int result = 0;
int a = value;
while(value > 0)
{
    result+= value%10;
    value = value/10;
}
Console.WriteLine($"{a}-> {result}");