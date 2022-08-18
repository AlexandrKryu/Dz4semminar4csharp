// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
if (number < 8)
{
    Console.Write("Неверный ввод, введите число >= 8, ");
    return;
}
int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < 8; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("->");
    Console.Write("[");
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int[] result = GetArray(number);
PrintArray(result);