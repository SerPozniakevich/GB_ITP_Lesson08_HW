// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Random rand = new Random();

void FillMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
            Console.Write($"{matr[i, j]}  ");
       } 
       System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


void SelectNumInLine (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int coul =0; coul < matr.GetLength(1); coul++) //счётчик для проведения сортировки в ячейках
        {
            for (int j = 1; j < matr.GetLength(1); j++)                                                     
            {
                while (matr[i, j] > matr[i, j - 1]) // проверка значений ячейки
                {
                    int temp = matr[i, j-1]; //temp - временная переменная
                    matr[i, j-1] = matr[i, j];     // обмен данных ежду переменными
                    matr[i, j] = temp; 
                }
                    
            }
        }
    }
}



int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintArray(matrix);
SelectNumInLine(matrix);

PrintArray (matrix);
