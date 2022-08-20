
//  Создаем двухмерный рандомный  массив  вещественных
double[,] SetArray(int rows, int columns, int min, int max)
{
   double[,] matrix = new double[rows, columns];
   Random rnd = new Random();


   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)

      {
         matrix[i, j] = rnd.Next(min, max + 1) + Math.Round(rnd.NextDouble(), 2);
      }
   }
   return matrix;
}



void PrintMatrixTwoDimensional(double[,] matrixTwoDimensional)
{
   for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
   {
      Console.Write("[ ");
      for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
      {
         if (matrixTwoDimensional[i, j] >= 0)
            Console.Write($" {matrixTwoDimensional[i, j]} ");
         else Console.Write($"{matrixTwoDimensional[i, j]} ");
      }
      Console.Write(" ]");
      Console.WriteLine();
   }
}


double[,] matr = SetArray(4, 4, 0, 10);

PrintMatrixTwoDimensional(matr);
Console.WriteLine();
