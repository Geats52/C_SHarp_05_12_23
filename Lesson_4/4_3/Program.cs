// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.
//Пример
//[1 3 2 4 2 3] => 132423
//[2 3 1] => 231

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

long CountNum(int[] arr)
{
string word = "";

foreach (int number in arr)
{
word += number;
}
return long.Parse(word);
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
long result = CountNum(mass);
Console.WriteLine(result);