// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using static System.Console;
//сейчас 4:04 утра 8 октября и я забыл сделать домашнее задание я сел за компьютер часов 5 назад и вот только сейчас
// я только закончил делать домашную работу у меня уже голова не варит как сделать скобки квадратные, так что я просто поставил запятые между числами
Write("Enter size of Array: ");
int num = int.Parse(ReadLine()!);
double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 100);
    Write(arrayRealNumbers[i] + " , ");
  }
  Write("=>");

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

WriteLine($"{maxNumber} - {minNumber} = {decision}");