/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → [“-2”]
["Russia", "Denmark", "Kazan"] → []
*/

string[] myArray = { "Russia", "Denmark", "Kazan" };
printArray(myArray);
createdArray(myArray);
Console.WriteLine();

void printArray(string[] myArray)
{
    Console.WriteLine($" \n Created array: ");
    Console.Write("[");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($" {myArray[i],1},");
    }
    Console.Write("] \n");
    Console.WriteLine();
    }

  void createdArray(string[] myArray)
{
    string[] newArray = new string[myArray.Length];
    Console.WriteLine("Array in which the length of strings is less than or equal to 3 characters:");
    Console.Write("[");
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            newArray[i] = myArray[i];
            Console.Write($" {myArray[i]},");
            
        }
    }
    Console.Write("]");
}

Console.WriteLine();  