/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//метод получения числа
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число.");
        }
    }
    return result;
}

//метод заполнения двумерной матрицы рандомными числами
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++) //0 - строка
    {
        for (int j = 0; j < n; j++) //1 - столбец
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

//метод вывода матрицы на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

//метод поиска стреднего арифметического каждого столбца
void AverageColumn(int[,] matrix)
{
    int summ = 0;
    double averageMatrixColumn;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ = 0;
        for (int j = 0; j < matrix.GetLength(0); j ++)
        {
            summ = summ + matrix[j,i];
        }
        Console.WriteLine($"Сумма элементов столбца : {summ}");
        averageMatrixColumn = (double) (summ / matrix.GetLength(0));
        Console.WriteLine($"Среднее арифметическое элементов столбца : {averageMatrixColumn}");
    }
}

int m = GetNumber("Введите количество строк матрицы: ");
int n = GetNumber("Введите количество столбцов матрицы: ");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
AverageColumn(matrix);
