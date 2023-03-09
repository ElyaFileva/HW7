Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

double[,] FillArray(int m, int n, int min, int max)
{
  double[,] result = new double[m, n];
  Random rnd = new Random();
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(min, max) + rnd.NextDouble();
    }
  }
  return result;
}

void PrintArray(double[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      Console.Write(Math.Round(inputArray[i, j], 2) + " ");
    }
    Console.WriteLine("");
  }
}
