// Создаем двухмерный рандомный массив

int[,] SetArray(int rows, int columns, int min, int max)
{
   var array = new int[rows, columns];
   var rnd = new Random();

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         array[i, j] = rnd.Next(min, max + 1);
      }
   }
   return array;
}

// ## Выводим двухмерный рандомный массив

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
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


int[,] matr = SetArray(4, 4, 0, 10);

PrintMatrixTwoDimensional(matr);
Console.WriteLine();


void AverageСolumn(int[,] matrix)
{
   double[] array = new double[matrix.GetLength(0)];
   double average = 0;
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      average = 0;
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         average += matr[i, j];
      }
      average = average / matr.GetLength(1);
      array[i] = average;
   }
   PrintArray(array);
}

AverageСolumn(matr);


// Метот который печатыет одномерный массив
void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (i == 0) Console.Write("[");
      if (i < array.Length - 1) Console.Write(array[i] + ",");
      else Console.Write(array[i] + "]");
   }
}

