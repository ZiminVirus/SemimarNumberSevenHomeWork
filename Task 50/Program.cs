// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Укажите какую ячейку в таблице Вы хотите найти");
Console.WriteLine("Введите номер строки");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int numColumns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void SerchAlementArray(int[,] matrix, int numberRow, int numberColumns)
{
    if (numberRow > matrix.GetLength(0) || numberColumns > matrix.GetLength(1))
        Console.WriteLine("Такого элемента в таблице нет!");
    else Console.WriteLine($"{matrix[numberRow - 1, numberColumns - 1]}");

}

int[,] array2D = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2D);
SerchAlementArray(array2D, numRow, numColumns);