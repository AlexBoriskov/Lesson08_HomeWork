// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void NewArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 6);
        }
    }
}

void PrintArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int [,] MultiplicationMatrix (int [,] array, int [,] matrix)
{
    int [,] result = new int [array.GetLength(0), matrix.GetLength(1)];
        for (int line=0; line<array.GetLength(0); line++)
        {
            for (int column=0; column<matrix.GetLength(1); column++)
            {
                for (int t=0; t<matrix.GetLength(0); t++)
                {
                    result [line, column] += array[line,t]*matrix[t,column];
                }
            }
        }
        return (result);
}

Console.Clear();
Console.Write ("Введите размер первой матрицы: ");
int[] sizeMatrixFirst = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write ("Введите размер второй матрицы: ");
int[] sizeMatrixSecond = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrixFirst = new int [sizeMatrixFirst[0], sizeMatrixFirst[1]];
int [,] matrixSecond = new int [sizeMatrixSecond[0], sizeMatrixSecond[1]];

NewArray(matrixFirst);
PrintArray(matrixFirst);
Console.WriteLine();
NewArray(matrixSecond);
PrintArray(matrixSecond);
Console.WriteLine();

if (sizeMatrixFirst[0] == sizeMatrixSecond[1])
{
Console.WriteLine("Результаты умножения 1 на 2 матрицу:");
int [,] matrixResult = MultiplicationMatrix(matrixFirst, matrixSecond);
PrintArray(matrixResult);
Console.WriteLine();
Console.WriteLine("Результаты умножения 2 на 1 матрицу:");
matrixResult = MultiplicationMatrix(matrixSecond, matrixFirst);
PrintArray(matrixResult);
}
else Console.WriteLine ("Ошибка! Данные матрицы перемножить нельзя!");