// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindNumber(int[,] matrix, int line, int column)
{
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1))
        {
            Console.WriteLine(matrix[line, column]);
        }
            else
        {
            Console.WriteLine($"{line}{column} - такого числа в массиве нет");
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
int[,] matrix = FillArray(10, 10, 0, 100);
PrintArray(matrix);
FindNumber(matrix, line, column);