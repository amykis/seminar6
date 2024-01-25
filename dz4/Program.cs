// Задача 4 *(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// Пример  
// “Hello my world” => “world my Hello” 

string GetReversWords(string input) {
    string[] words = input.Split(' ');
    Array.Reverse(words);
    string result = "";
    foreach(string item in words) {
       result += $"{item}" + " ";
    }
    return result.Trim();
}

string input = "Hello my world";
Console.WriteLine(GetReversWords(input));