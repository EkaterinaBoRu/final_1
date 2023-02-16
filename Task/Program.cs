// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна 3 символам.

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

string[] createArray(int lenght)
{
    string[] result = new string[lenght];
    for (int i=0; i< lenght; i++)
    {
        result[i]= Console.ReadLine();
    }
    return result;
}

void CountSymbol(string[] arr)
{
    Console.Write("[");
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i].Length<=3) Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int lenght = getUserData("Введите количество строк в массиве");
string[] array = createArray(lenght);

Console.WriteLine();
Console.WriteLine("Небольше трех символов:");
CountSymbol(array);



