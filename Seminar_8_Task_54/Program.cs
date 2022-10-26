//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix =
{
    {5,1,9,4},
    {5,1,9,4},
};


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);
Console.WriteLine();


void Method(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] < matr[i, j]) min = k;
            }
            int temp = matr[i,j];
            matr[i,j] = matr[i,min];
            matr[i,min] = temp;

        }
    }
}


Method(matrix);
PrintMatrix(matrix);





// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int min = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[min]) min = j;
//         }

//         int temp = array[i];
//         array[i] = array[min];
//         array[min] = temp;
//     }
// }
