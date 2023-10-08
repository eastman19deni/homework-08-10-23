// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System.Runtime.Serialization;
using static System.Console;

Write("Enter size of Array: ");
int num = int.Parse(ReadLine()!);
int min = 1;
int max = 99;
int[] Array = GetArray(num, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindOdd(Array);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}
void FindOdd(int[] array)
{
    int odd = 0;
    for (int i = 0; i < Array.Length; i += 2)
    {
        odd += array[i];
    }
    WriteLine($"Odd numbers:{odd}");
}