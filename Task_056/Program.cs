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


void FillMatrix (int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
            System.Console.Write($"{matr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}


int[,] matrix = new int[3, 4];

FillMatrix(matrix);

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
                arrSummLine[n] = summLine; 
            }

        }
        System.Console.Write($"{arrSummLine [matrix.GetLength(0)-1]} ");
    }
}






int minSummLine = Summes[0];
int minNum = 0;   
for (int n = 1; n < matrix.GetLength(0) - 1; n++)
{
    if (minSummLine < Summes [n])
    {
         minSummLine = Summes[n-1];
         minNum = n++;
    }
    System.Console.WriteLine();
    Console.WriteLine(Summes[minNum]);
}
// Console.WriteLine($"\n{minSummLine}");









