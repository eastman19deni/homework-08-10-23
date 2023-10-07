// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using static System.Console;

Write("Enter size of Array: ");
int num = int.Parse(ReadLine()!);
int min = 99;
int max = 999;
int[] Array = GetArray(num, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindEven(Array);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}
void FindEven(int[] array)
{
    int even = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            even += 1;
        }
    }
    WriteLine($"Even numbers:{even}");
}
