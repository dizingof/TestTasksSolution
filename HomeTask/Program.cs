using System;

class Program
{
    static int R = 4;
    static int C = 4;

    // Переворачиваем матрицу
    static void reverseColumns(int[,] arr)
    {
        for (int i = 0; i < C; i++)
            for (int j = 0, k = C - 1;
                j < k; j++, k--)
            {
                int temp = arr[j, i];
                arr[j, i] = arr[k, i];
                arr[k, i] = temp;
            }
    }

    //Транспонируем матрицу 
    static void transpose(int[,] arr)
    {
        for (int i = 0; i < R; i++)
            for (int j = i; j < C; j++)
            {
                int temp = arr[j, i];
                arr[j, i] = arr[i, j];
                arr[i, j] = temp;
            }
    }

    // Вывод матрицы в консоль 
    static void printMatrix(int[,] arr)
    {

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
                Console.Write(arr[i, j] + " ");
            Console.WriteLine("");
        }
    }


    static void Main()
    {
        int[,] arr = { { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 } };

        transpose(arr);
        reverseColumns(arr);
        printMatrix(arr);
        Console.ReadKey();
    }
}
