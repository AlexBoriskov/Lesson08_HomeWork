// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void NewArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 11);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void SortLine (int [] array)
{
    int minimum = array[0];
    int minIndex = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (minimum > array[i])
        {
            minimum = array[i];
            minIndex=i+1;
        }
    }
    Console.WriteLine("Минимальная сумма в строчке №" + minIndex);
}

void SummaLine (int [,] array)
{
    int count = 0;
    int [] s = new int [array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)  {s[i] += array[i,j];}
    }
    Console.WriteLine (string.Join(", ", s));
    SortLine (s);
}

Console.Clear();
Console.Write ("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];

NewArray(matrix);
Console.WriteLine();
SummaLine(matrix);
