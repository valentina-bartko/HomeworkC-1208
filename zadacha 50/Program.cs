// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void SearchElement (int[,] arr)
{
    Console.WriteLine();
    Console.Write("Введите номер строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i <= arr.GetLength(0) && j <= arr.GetLength(1))
    {
        Console.WriteLine();
        Console.Write($"Число: {arr[i-1,j-1]}");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Такого числа в массиве нет");
    }
}

int m = new Random().Next(3,6);
int n = new Random().Next(3,6);
int[,] array =  new int[m,n];

FillArray(array);
PrintArray(array);
SearchElement(array);