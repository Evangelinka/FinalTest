// Программа, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void CreateSecondArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4)
        {
            array2[i] = array1[i];
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

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
CreateSecondArray(array1, array2);
PrintArray(array2);
