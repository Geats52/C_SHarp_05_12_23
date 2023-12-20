//Задание 3. Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
//Пример
//“hello” => 2
//“world” => 1

bool Palindrom(string word)
{
    int size = word.Length;
    for(int i = 0; i < size / 2; i++)
    {
        if (word[i] != word[size - 1 - i])
            return false;
    }
    return true;    
}

Console.Write("Enter some text: ");
string text = Console.ReadLine()!;

string res = Palindrom(text);
Console.Write($"Pharse is palindrom");

// Мое решение
// int CountVowels(string word)
// {
// char[] vowels = {'a', 'e', 'i', 'o', 'u'};
// int count = 0;

// foreach (var item in word)
// {
// if (Array.IndexOf(vowels, item) != -1)
// {
// count++;
// }
// }

// return count;
// }

// Console.Write("Enter some text: ");
// string text = Console.ReadLine()!;

// int res = CountVowels(text);
// Console.WriteLine(res);