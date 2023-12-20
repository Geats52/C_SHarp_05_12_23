// Задание 3. Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void StringCons(string word, int ind = 0)
{
    if (ind == word.Length) return;
    if("zxcvbnmsdfghjklptrrwq".Contains(char.ToLower(word[ind])))
        Console.Write($"{word[ind]}");
    StringCons(word, ind + 1);
}

Console.Write("Enter some text: ");
string text = Console.ReadLine()!;
StringCons(text);
