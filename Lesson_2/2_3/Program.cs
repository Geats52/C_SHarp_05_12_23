//Программа, которая принамет на вход 2 числа и выводит, является ли второе число кратным первому.
//Если второе число некратно первому, то программа выводит остаток от деления

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a % b == 0)
    Console.WriteLine("Multiply");
else
    Console.WriteLine($"Multiply {a} % {b} = {a % b}");
