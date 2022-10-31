// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = {
    {2,4},
    {3,2},
};

int[,] matrix2 = {
    {3,4},
    {3,3},
};


void Multiply(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        int res = 0;

        for (int k = 0; k < matr2.GetLength(1); k++)
        {
            res = 0;
            for (int j = 0; j < matr2.GetLength(0); j++)
            {
                res = res + matr1[i, j] * matr2[j, k];

                // Console.WriteLine($"{matr1[i, j]} * {matr2[j, k]}");
            }
            matr3[i, k] = res;
            Console.Write($"{matr3[i, k]} ");
        }

        Console.WriteLine();
    }
}

Multiply(matrix1, matrix2);




