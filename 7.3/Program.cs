Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

int[,] FillArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  Random rnd = new Random();
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(min, max);
    }
  }
  return result;
}

void PrintArray(int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      Console.Write(inputArray[i, j] + " ");
    }
    Console.WriteLine("");
  }
}
double sum = 0;
Console.WriteLine("Среднее арифметическое столбца ");
for (int j = 0; j < array.GetLength(1); j++)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sum += array[i, j];
  }
  double arithmeticMean = Math.Round(sum / array.GetLength(0), 2);
  Console.WriteLine($"{j}: {arithmeticMean}; ");
  sum = 0;
}