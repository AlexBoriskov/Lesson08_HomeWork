// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void NewArray (int [,,] array)
{
    int t = 10;
    array [0,0,0] = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int z=0; z<array.GetLength(2); z++)
            {
                array [i,j,z] += t;
                t++;
            }
        }
    }
}

void PrintArray (int [,,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int z=0; z<array.GetLength(2); z++)
            {
                Console.Write ($"{array[i,j,z]}({i},{j},{z}) \t");  
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write ("Введите размер матрицы: ");
int[] sizeMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,,] matrix= new int [sizeMatrix[0], sizeMatrix[1], sizeMatrix[2]];


NewArray(matrix);
PrintArray(matrix);
Console.WriteLine();
