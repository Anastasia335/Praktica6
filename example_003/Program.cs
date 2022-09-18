// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = new Random().Next(1,10);
}
}
}
Console.Write("Введите колличество строк первой матрицы: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первой матрицы: ");
int stolb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк второй матрицы: ");
int secstr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второй матрицы: ");
int secstolb = Convert.ToInt32(Console.ReadLine());
int[,] OneArray = new int[str, stolb];
int[,] SecondArray = new int[secstr, secstolb];
int[,] ResultArray = new int[str, stolb];
Console.WriteLine();
FillArray(OneArray);
PrintArray(OneArray);
Console.WriteLine();
FillArray(SecondArray);
PrintArray(SecondArray);
Console.WriteLine();

if (OneArray.GetLength(0) != SecondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить матрицы");
    return;
}
for (int i = 0; i < OneArray.GetLength(0); i++)
{
    for (int j = 0; j < SecondArray.GetLength(1); j++)
    {
        ResultArray[i, j] = 0;
        for (int k = 0; k < OneArray.GetLength(1); k++)
        {
            ResultArray[i, j] += OneArray[i, k] * SecondArray[k, j];
        }
    }
}

PrintArray(ResultArray);
