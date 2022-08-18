// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumNum(int num)
{
    int res = 0;
    for (int i = 1; i < num; i++)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
int result = SumNumNum(number);
Console.WriteLine($"{number} -> {result}");