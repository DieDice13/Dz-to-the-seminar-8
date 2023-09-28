Console.Clear();

int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(1, 99);
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);
