// Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом массиве.
//Примеры
//[1 3 4 19 3] => 2
//[4 3 4 1 9 5 21 13] => 3

//Простое чмсло - делиться на себя и на единицу

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

int SimpleNum(int[] arr)
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
int result = SimpleNum(mass);
Console.WriteLine(result);