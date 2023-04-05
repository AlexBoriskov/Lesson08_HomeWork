// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void NewArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10, 10);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void SortMatrix (int [,] array, int i)
{
    for (int t=0; t<array.GetLength(1); t++)
    {
        for (int z=0; z<array.GetLength(1)-1; z++)
        {
            if (array[i,z]>array[i,z+1])
            {
                int m = array [i, z];
                array [i,z] = array [i, z+1];
                array [i, z+1] = m;
            }
        }
    }
}

void ReleaseMatrix (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            SortMatrix(array, i);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write ("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];

NewArray(matrix);
Console.WriteLine();
ReleaseMatrix (matrix);