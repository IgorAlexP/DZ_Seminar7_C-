/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
float[,] matrix = new float[m, n];

PrintArray(matrix);
Console.WriteLine("Среднее арифметическое стобцов массива:");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    float sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"| { sum / matrix.GetLength(0)} | ");
}

void PrintArray(float[,] matr)          //метод создания массива чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
