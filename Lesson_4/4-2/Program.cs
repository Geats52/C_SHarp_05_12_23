//Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и
//делятся нацело на 7.
//Пример
//[1 5 11 21 81 4 0 91 2 3]
//=> 2
 
void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
arr[i] = new Random().Next(from, to + 1);
return arr;
}

bool IsPrime(int number)
{
if (number < 2)
return false;

for (int i = 2; i <= Math.Sqrt(number); i++)
{
if (number % i == 0)
return false;
}
return true;
}

int CountNum(int[] arr)
{
int count = 0;

foreach (int number in arr)
{
if (IsPrime(number))
count++;
}
return count;
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int result = CountNum(mass);
Console.WriteLine(result);