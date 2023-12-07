// Задача: Задать массив. Написать программу, которая определяет, присутствует ли заданое число в массиве. Программа должна выдать ответ: да или нет.

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string IfNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
            return "Yes";
    }
    return "No";
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(IfNum(mass, number));
