/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */
Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер строки массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(a == i && b == j)
            {
                Console.Write($"Элемент массива с номером строки {a} и номером столбца {b} => {matrix[i, j]}");
            }
        }
    }
if(a >= matrix.GetLength(0) || b >= matrix.GetLength(1))
        {
            Console.Write($"Элемента с номером строки {a} и номером столбца {b} в массиве нет");
        }

void PrintArray(int[,] matr)          //метод создания массива чисел
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

