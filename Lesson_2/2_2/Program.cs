//Программа, которая принимает на вход трёхзначное число в возводит вотрую цифру этого числа в степень, равную третьей цифре
int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
int n2 = n / 10 % 10;
Console.WriteLine(Math.Pow(n2, n3));
