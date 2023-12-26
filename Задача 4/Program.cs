// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


static string ReverseWords(string str)
{
string[] words = str.Split(' ');
Array.Reverse(words);
return string.Join(" ", words);
}

//------------------------


string input = "Приветствую тебя, командир!";
string result = ReverseWords(input);
Console.WriteLine(result);


