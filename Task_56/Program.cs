int[,] table = new int[ReadInt("Введите число строк") , ReadInt("Введите число столбцов")];
FillArrayRandom(table, ReadInt("Введите число max для рандома"));
PrintArray(table);
 int[] sum = new int[table.GetLength(0)];
Sum(table, sum);
AsmallLine(sum);




void AsmallLine(int[] sum)
{
    int index = 1;
    int min = sum[0];
for(int i = 0; i < sum.Length; i++)
{
    if(sum[i] < min)
    {
      min = sum[i];
      index = i + 1;
    }
    
}
Console.WriteLine("Cтрока с меньшей суммой элементов ->" + index);
}
int ReadInt(string message)
{
    Console.Write(message + "->");
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandom(int[,] array, int range)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random ().Next (1, range);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Sum(int[,] array, int[] sum)
{
    for(int i = 0; i < array.GetLength(0); i++)
     {
      for(int j = 0; j < array.GetLength(1); j++)
      {
        sum[i] += array[i,j];
      }
      //Console.WriteLine(sum[i]);
     } 
     
}