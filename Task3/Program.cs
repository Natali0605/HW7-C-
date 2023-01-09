// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageArithmetic(int[,] matrix, int line, int column)
{
    for (int i = 0; i < column; i++)
    {
        double sum = 0;
        for (int j = 0; j < line; j++)
        {
          sum = sum + matrix[j,i];
        }
    double average = sum / line;
    Console.Write($"{average}; ");
    }
}
void PrintArray(int[,] arr)
{
 for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int line, int column, int begin, int end)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(begin, end);
        }
    }
    return array;
}
int EnterDate(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int line = EnterDate("Введите количество строк: ");
int column = EnterDate("Введите количество столбцов: ");
int[,] matrix = FillArray(line, column, 0, 10);
PrintArray(matrix);
AverageArithmetic(matrix, line, column);
