//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[4, 3];


void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 20);
            Console.Write($" {matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix);


int FindElement(int[,] matr)
{
    int res = 0;
    Console.Write("Input rows: ");
    int rows = Int32.Parse(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == rows & j == columns)
            {
                res = matr[i, j];
            }
            // else
            // {

            // }
        }
    }
    return res;
}

int res = FindElement(matrix);

if (res == 0)
{
    Console.WriteLine($"! такого элемента нет !");
}
else
{
    Console.WriteLine($"The element: {res}");
}


