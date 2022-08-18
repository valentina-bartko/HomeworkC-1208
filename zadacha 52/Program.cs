// Задайте двумерный массив из целых чисел размера NxN. Укажите два числа,
// означающие строки, которые нужно поменять местами.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 9 8 7 2
// Число 1 - 1
// Число 2 - 3

// Итог:
// 1 4 7 2
// 9 8 7 2
// 8 4 2 4
// 5 9 2 3

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

void Transposition(int[,] arr)
{
    Console.Write("Введите номер первой строки (отчсёт с нуля): ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер второй строки (отсчёт с нуля): ");
    int y = Convert.ToInt32(Console.ReadLine());
    int temp;
    for (int j = 0; j < arr.GetLength(1); j ++)
    {
        temp = arr[x,j];
        arr[x,j] = arr [y,j];
        arr[y,j] = temp;
    }
}

int n = new Random().Next(3,6);
int[,] array = new int[n,n];

FillArray(array);
PrintArray(array);
Transposition(array);
PrintArray(array);