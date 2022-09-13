// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
System.Console.WriteLine($"______________");
int i = 2;
int j = 2;
int[,] matrix1 = new int[i, j];
FillMatrix(matrix1);
PrintArray(matrix1);
Console.WriteLine();
int m = i;
int n = j;
int[,] matrix2 = new int[m,  n];
FillMatrix(matrix2);
PrintArray(matrix2);
Console.WriteLine("Результирующая матрица будет:");
MultiMatrixs (matrix1, matrix2);


void FillMatrix (int[,] matr)
{
    Random rand = new Random();
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
       Console.WriteLine();
    }
}

void MultiMatrixs (int[,] matrix1, int[,] matrix2)
{
  int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

  for (int l = 0; l < matrix1.GetLength(0); l++)
  {
    for (int f = 0; f < matrix2.GetLength(1); f++)
    {
      for (int k = 0; k < matrix2.GetLength(0); k++)
      {
        matrix3[l, f] += matrix1[l, k] * matrix2[k, f];//(i,j * m, n) + (i, j+1 * m+1, n)
      }
      Console.Write($"{matrix3[l, f]} ");
    
    }
    Console.WriteLine();
  }
}




