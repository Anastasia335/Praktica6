// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
Console.Write("Введите колличество строк:");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов:");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[str, stolb];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int minSum = 0;
int sum = SumElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSum = SumElements(matrix, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} строкa с наименьшей суммой элементов. Сумма = {sum} ");


int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}