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

int row = 4;
int col = 4;
int[,] matrix = new int[row, col];

FillMatrix(matrix);

int [] AmountsLine = new int [row];

Fillarray (AmountsLine);

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

void Fillarray (int [] arr)
{
    int [] arrSummLine = new int [row];
 
    Console.WriteLine($"Сумма чисел каждой строки: ");
    for (int i = 0; i < row; i++) //Начинаем со Строк, так как по ним надо посчитать сумму
    {
        int summLine = 0;
        for (int j = 0; j < col; j++)
        {
            summLine += matrix[i, j];
            for (int n = 0; n < row; n++)
            {
                arr[n] = summLine;
            }
        }
        System.Console.Write($"{arr[row-1]} ");
    }
}


int minSummLine = AmountsLine[0];
int minIndex = 1;  
for (int coul = 0; coul < row*2; coul++)
{  
    for (int i = 1; i < row; i++)
    {
        if (AmountsLine[i] < minSummLine)
        {
            minSummLine = AmountsLine[i];
            minIndex = i+1;
        } 
    }
    // Console.Write($"\n{minSummLine}");
    // Console.WriteLine($"\n{minIndex}");
}

Console.Write($"\n{minSummLine}");
Console.WriteLine($"\n{minIndex}");









