// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

// m = 3, n = 4
// 0,5   7   -2   -0,2
//  1  -3,3   8   -9,9
//  8   7,8  -7,1   9

// Я понимаю задачу так: m и n автоматически генерируются из дипазона [3,5].

Random rand = new Random();

// Метод заполнения массива
void FillArray(double[,] arr)
    {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.NextDouble() * 20 + -10;
        }
    }
    }

// Метод печати массива
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:F1}  ");
        }
        Console.WriteLine();
    }
}

int m = rand.Next(3,6);
int n = rand.Next(3,6);

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);