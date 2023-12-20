// Задание 1. Задайте массив символов (тип char []). Создайте строку из символов этого массива. 
//Указание Конструктор строки вида string(char []) не использовать.Пример[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string ChArrToStr(char[] arr)
{
    string result = "";
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            result += arr[i, j];
    return result;
}

char[,] charArray ={
    {'H', 'e', 'l', 'l', 'o', ','}
    {'W', 'o', 'r', 'l', 'd', '!'};
    
    };
string res = ChArrToStr(charArray);
Console.WriteLine(res);















// Неполная версия

// string ChArrToStr(char[] arr)
// {
//     string result = "";
//     foreach (var item in arr)
//     {
//         result += item;
//     }
//     return result;
// }

// char[] massChar = {'P', 'e', 'o', 'p', 'l', 'e'};
// string res = ChArrToStr(massChar);
// Console.WriteLine(res);