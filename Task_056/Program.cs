// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            Console.Write($"{arr[i, j]}  ");
       } 
       System.Console.WriteLine();
    }
}



int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintArray(matrix);
int [] Summes = new int [matrix.GetLength(0)];
ShowSummLines (Summes);


void ShowSummLines (int [] Summes)
{
    Console.WriteLine($"Сумма чисел каждой строки: ");
    for (int i = 0; i < matrix.GetLength(0); i++) //Начинаем со Строк, так как по ним надо посчитать сред.арифм.
    {
        int [] arrSummLine = new int [matrix.GetLength(0)];
        int summLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summLine += matrix[i, j];
            for (int n = 0; n < matrix.GetLength(0); n++)
            {
                Summes[n] = summLine; 
            }
        }
        System.Console.Write($"{Summes[matrix.GetLength(0) - 1]}; ");
    }
}






int minSummLine = Summes[0];
// int minNum = 0;   
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    if (minSummLine > Summes [i])
    {
        minSummLine = Summes[i];
        // minNum = i++;
    }
    else i++;
}
Console.WriteLine($"\n{minSummLine}");









