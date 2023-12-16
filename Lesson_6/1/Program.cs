// Задание 1. Задайте массив символов (тип char []). Создайте строку из символов этого массива. 
//Указание Конструктор строки вида string(char []) не использовать.Пример[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string ChArrToStr(char[] arr)
{
    string result = "";
    foreach (var item in arr)
    {
        result += item;
    }
    return result;
}

char[] massChar = {'P', 'e', 'o', 'p', 'l', 'e'};
string res = ChArrToStr(massChar);
Console.WriteLine(res);
