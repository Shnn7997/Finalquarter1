using System;
using static System.Console;

Clear();

Write("Введите массив строк через пробел без запятых: ");
string[] array = GetArrayFromString(ReadLine());
string[] array2 = new string[array.Length];
WriteLine($"[{String.Join(", ", array)}]");
ArrayFinal(array, array2);
Write("массив, где длина строк <=3: ");
PrintArray(array2);


string[] GetArrayFromString(string arrayStr)
{
    string[] arS = arrayStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[arS.Length];
    for (int i = 0; i < arS.Length; i++)
    {
        result[i] = arS[i];
    }
    return result;
}

void ArrayFinal(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
