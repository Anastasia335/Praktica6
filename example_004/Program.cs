// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
    if (matr[i,j] < 10) Console.Write($"0{matr[i, j]} ");
    else Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
Console.Write("Введите размерность N матрицы N*N : ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[N, N];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= Array.GetLength(0) * Array.GetLength(1))
{
  Array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Array.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray (Array);