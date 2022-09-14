// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Hello, World!");

int row = 2;
int col = 2;
int dep = 2;

int[, ,] matrix = new int[row, col, dep];

FillMatrix(matrix);

void FillMatrix (int[, ,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                matr[i, k, j] = rand.Next(10, 100);
                
                System.Console.Write($"{matr[i, k, j]} ({i},{k},{j})  ");
            }
            System.Console.WriteLine();
        }
    }
}
