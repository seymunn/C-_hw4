// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int NumSum(int num)
{
    int sum = 0;
    int num2 = 0;
    while (num > 0)
    {
        num2 = num % 10;
        sum += num2;
        num /= 10;
    }
    return sum;
}
int result = NumSum(number);
Console.WriteLine($"{number} -> {result}");