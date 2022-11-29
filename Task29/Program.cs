// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array = new int[8];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
}
void PrintArray()
{
    FillArray();
    Console.Write("[");
        for (int i = 0; i < 8; i++)
    {
        if (i == 7)
        {
            //Console.Write($"{array[i]}, ");
            Console.Write(array[i]);
        }
        else
        {
            //Console.Write(array[i]);
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
}
PrintArray();