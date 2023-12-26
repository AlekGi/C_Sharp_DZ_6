// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string Concat(char[,] array)
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
        str = str + array[i,j];
        str += " ";
        }
    }
    return str;
}
void Print2DArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

char[,] letters = {{ 'a', 'b', 'c', 'd' }, { 'e', 'f', 'g', 'h'}};
string result = Concat(letters);
System.Console.WriteLine("Наш массив: ");
Print2DArray(letters);
System.Console.WriteLine("Получили из него строку: ");
System.Console.WriteLine(result);