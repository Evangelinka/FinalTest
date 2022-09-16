// Программа, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void CreateSecondArray(string[] sourceArray, string[] formedArray)
{
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length < 4)
        {
            formedArray[i] = sourceArray[i];
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

string[] sourceArray = new string[4] {"hello", "2", "world", ":-)"};
string[] formedArray = new string[sourceArray.Length];
CreateSecondArray(sourceArray, formedArray);
PrintArray(formedArray);