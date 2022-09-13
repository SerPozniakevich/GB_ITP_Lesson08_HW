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
Console.WriteLine($"Сумма чисел каждой строки: ");
FillArray (AmountsLine);

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

void FillArray (int [] arr)
{
    int [] arrSummLine = new int [matrix.GetLength(0)];
 
    for (int i = 0; i < matrix.GetLength(0); i++) //Начинаем со Строк, так как по ним надо посчитать сумму
    {
        int summLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summLine += matrix[i, j];
            arr[i] = summLine;
        }
        System.Console.Write($"{arr[i]} ");
    }
}

int lineMinSumm = AmountsLine[0];
int indexMinSum = 1;
for (int i = 0; i < row; i++)
{
    if (AmountsLine[i] < lineMinSumm)
    {
        lineMinSumm = AmountsLine[i];
        indexMinSum = i+1;
    }  
}
Console.WriteLine($"\nНаименьшая сумма элементов: {indexMinSum} строка");








