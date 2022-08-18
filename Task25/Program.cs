// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите любое целое положительное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());

int degreeAB(int deg1, int deg2)
{
    int res = 1;
    for (int i = 1; i <= deg2; i++)
    {
        res = res * deg1;
    }
    return res;
}
int result = degreeAB(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {result}");
