// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7},
};

int Method(int[,] matr, int x)
{
    int sum = new int();
    for (int i = 0; i < x; i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
    }
    return sum;
}



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)

    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min]) min = j;
            //Console.WriteLine($"{array[j]} < {array[min]}");
        }

        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}



void TheLess(int[,] matr)
{
    int sum = new int();

    int temp = new int();
    int sumResult = int.MaxValue;
    int min = int.MaxValue;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }


        if (sum < min && sum < sumResult)
        { sumResult = sum; temp = i + 1; }
        min = sum;

    }
    Console.WriteLine("номер строки с наименьшей суммой элементов: " + $"{temp} строка");

}


PrintArray(matrix);
TheLess(matrix);




//Console.WriteLine(sumResult);


// SelectionSort(array);
// PrintArray(array);


//x = i;
// Console.WriteLine(N);
// Console.WriteLine();

//   SelectionSort(array);
//    Console.WriteLine();
//     PrintArray(array);

//Console.Write($"{array[i]} ");



// for (i = 0; i < array.Length - 1; i++)
// {
//     int min = i;
//     for (int k = i + 1; k < array.Length; k++)
//     {

//         if (array[k] < array[i]) min = k;
//     }
//     int temp = array[i];
//     array[i] = array[min];
//     array[min] = temp;

// }
//  Console.Write($"{array[i]}");





