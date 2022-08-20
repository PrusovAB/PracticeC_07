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


Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

// Метод поиска элемента в массиве

void SearchElementPos(int[,] matrix, int x, int y)
{
   if (matrix.GetLength(0) - 1 < x || matrix.GetLength(1) - 1 < y)
   {
      Console.WriteLine("Вы задали кординаты превышающие размеры массива");
   }
   else
   {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         if (i == x)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               if (j == y)
               {
                  Console.WriteLine($"На заданных координатах находится чисдл {matrix[i, j]}");
               }
            }
         }
      }
   }
}

SearchElementPos(matr, a, b);