// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray2DimRandom(int row, int column, int maxEl)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, maxEl);
        }
    }
    return array;
}
void PrintArray2Dim(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int SumElInRow(int[,] array, int numberRow)
{
    int sumEl = array[numberRow, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumEl += array[numberRow, j];
    }
    return sumEl;
}
Console.Clear();
int valueMaxElArray = new Random().Next(4, 10);
int rowArray = new Random().Next(4, valueMaxElArray);
int columnArray = new Random().Next(4, valueMaxElArray);
int[,] someArray = CreateArray2DimRandom(rowArray, columnArray, valueMaxElArray);

Console.WriteLine($"Массив {rowArray}x{columnArray}, значения от 1 до {valueMaxElArray}:");
PrintArray2Dim(someArray);

int sum = 0;
for (int i = 0; i < rowArray - 1; i++)
{
    if (SumElInRow(someArray, i + 1) < SumElInRow(someArray, i)) sum = i + 1;
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {sum+1} строка");