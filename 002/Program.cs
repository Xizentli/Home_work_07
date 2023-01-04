/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
    for (int i = 0; i < matrix.GetLength(0); i++) //0 - строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //1 - столбец
        {
            matrix[i,j] = rnd.Next(-10, 10);
            
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

//метод поиска элемента матрицы по его индексу
bool ScanMatrix(int[,] matrix)
{
    int indexString = GetNumber("Введите индекс строки элемента: ");
    int indexColumn = GetNumber("Введите индекс столбца элемента: ");
    bool result = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == indexString && j == indexColumn)
            {
                result = true;
                break;
            }
        }
    }
    if(result) //если истина 
    Console.WriteLine("Такой элемент есть в матрице.");
    else 
    Console.WriteLine("Такого элемента нет.");
    return result;
}

Console.WriteLine("1. Создание матрицы.");
int m = GetNumber("Введите количество строк матрицы: ");
int n = GetNumber("Введите количество столбцов матрицы: ");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("2. Поиск элемента матрицы.");
bool scanMatrix = ScanMatrix(matrix);



