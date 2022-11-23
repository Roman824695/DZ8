int[,] table = new int[ReadInt("Введите число строк") , ReadInt("Введите число столбцов")];
Checing(table.GetLength(0), table.GetLength(1));

void Checing(int num1, int num2)
{
   if(num1 == num2)
{
FillArrayRandom(table, ReadInt("Введите число max для рандома"));
PrintArray(table);
Console.WriteLine();
PrintArray2(table);
}
else
{
    Console.WriteLine("Действие не возможно так как количество строк не совпадает с количеством столбцов");
}
 
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
void PrintArray2(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[j, i]} ");
        }
        Console.WriteLine();
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