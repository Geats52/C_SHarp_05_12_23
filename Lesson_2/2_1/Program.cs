//Программа, кторая вытаскивает 2 число из трёхзначного числа, делая его двухзначным
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n / 100 * 10 + n % 10);
