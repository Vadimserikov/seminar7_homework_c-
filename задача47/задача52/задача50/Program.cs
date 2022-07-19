// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[n, m];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(-100, 100)/ 10;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void shownumber(int [,]matrix)
{
if (m >= matrix.GetLength(0) || n >= matrix.GetLength(1) || n < 0 || m < 0 )
{
    Console.WriteLine("Такого элемента нет");
}
else
Console.WriteLine(matrix[n,m]);
}

int[,] matrix = InitMatrix(m, n);
shownumber(matrix);
PrintMatrix(matrix);
