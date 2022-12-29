// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6



int[,] array = new int[2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] array1 = new int[2,2];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] arraySum = new int[2,2];
for (int i = 0; i < arraySum.GetLength(0); i++)
{
    for (int j = 0; j < arraySum.GetLength(1); j++)
    {
        
        arraySum[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            arraySum[i,j] = array[i, j] * array1[i, j];
        }
                 Console.Write(arraySum[i,j] + "  ");
    }
    Console.WriteLine();
}

