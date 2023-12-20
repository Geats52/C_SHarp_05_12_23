//Задание 2. Обсуждение решения На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
//Пример “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’] 

string LowUp(string word)
{
    return word.ToLower();    
}

Console.Write("Enter some text: ");
string text = Console.ReadLine()!;

string res = LowUp(text);
Console.Write(res);













// мой вариант
// char[] StrToChArr (string word)
// {
//     int len = word.Length;
//     char[] result = new char[len];

//     for(int i = 0; i < len; i++)
//         result[i] = word[i];
//     return result;    
// }

// string hi = "Hello";
// char[] charArr = StrToChArr(hi);

// foreach (var item in charArr)
// {
//     Console.Write(item + ", ");
// }