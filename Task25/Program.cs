// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите первое число:");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second_num = Convert.ToInt32(Console.ReadLine());

int MultNum(int number1, int number2)
{
    int power_of_num = 1;
    for (int i = 1; i <= number2; i++)
    {
        power_of_num *= number1;
    }
    return power_of_num;
}
if (second_num > 0)
{
    int result = MultNum(first_num, second_num);
    Console.WriteLine($"{first_num}, {second_num} -> {result}");
}
else
{
    Console.WriteLine("Введено недопустимое значение");
}