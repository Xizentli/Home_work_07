/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

//метод заполнения двумерной матрицы рандомными вещественными числами
double[,] InitMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //0 - строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //1 - столбец
        {
            matrix[i,j] = rnd.Next(-10, 10) + rnd.NextDouble();
            
        }
    }
    return matrix;
}

//метод вывода матрицы на консоль
void PrintMatrix(double[,] matrix)
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


int m = GetNumber("Введите количество строк матрицы: ");
int n = GetNumber("Введите количество столбцов матрицы: ");
double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);





