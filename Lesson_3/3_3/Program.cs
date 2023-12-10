// Задание: Найдите произведения пар числе в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив

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

int[] PairNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * arr[size - i -1];
    }
    if (size % 2 == 1)
        new_arr[flex_size - 1] = arr[size / 2];
    return new_arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int[] new_mass =PairNum(mass);
Print(new_mass);