// Вводные данные
string[] arrayStr = new string[] { "hello", "2", "world", ":-)" };
// string[] arrayStr = new string[] { "1234", "1567", "-2", "computer science" };
// string[] arrayStr = new string[] { "Russia", "Denmark", "Kazan" };
int doesNotExceed = 3;
System.Console.WriteLine("Исходный массив строк: ");
PrintArray(arrayStr);

// Решение
string[] arrayDoesNotExceedThreeSymbols = GetArrayDoesNotExceedThreeSymbols(arrayStr, doesNotExceed);
System.Console.WriteLine("Сформированный массив строк: ");
PrintArray(arrayDoesNotExceedThreeSymbols);

// методы
// 1. получить массив, в котором все элементы-строки не будут превышать 3 символов 
string[] GetArrayDoesNotExceedThreeSymbols(string[] array, int maxLengthStr)
{
    int current = 0;
    string[] arrayTemp = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthStr)
        {
            arrayTemp[current] = array[i];
            current++;
        }
    }
    string[] arrayFinal = new string[current];
    for (int j = 0; j < current; j++)
    {
        arrayFinal[j] = arrayTemp[j];
    }
    return arrayFinal;
}
// 2. метод печати массива
void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        System.Console.Write("[ ");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write($"{array[i]}, ", 4);
        }
        System.Console.Write($"{array[array.Length - 1]}", 4);
        System.Console.WriteLine(" ]");
    }
    else System.Console.WriteLine("[ ]");
}
