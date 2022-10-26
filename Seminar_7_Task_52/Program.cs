// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4];

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}


void Average(int[,] matr)
{

    double average = 0;
    double row = matr.GetLength(0);
    double column = matr.GetLength(1);
    
    for (int j = 0; j < column; j++)
    {
        double sum = 0;
        for (int i = 0; i < row; i++)
        {
            sum = (sum + matr[i, j]);
        }
        average = Math.Round((sum / row), 2);
        Console.Write($" {average}; ");
    }
}


FillMatrix(matrix);
Console.Write("Среднее арифметическое каждого из столбцов:");
Average(matrix);


