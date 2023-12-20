// Задание 2. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void ValueSet(int num)
{
    if (num == 0) return;
    ValueSet(num - 1);
    Console.WriteLine($"{num } ");
}

ValueSet(5);// 1 2 3 4 5
// ValueSet(4) 1 2 3 4
// ValueSet(3) 1 2 3 
// ValueSet(2) 1 2
// ValueSet(1) 1
// ValueSet(0) x