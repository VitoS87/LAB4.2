try
{
int x = 0;
Random rand = new Random();
int[,] mas = new int[7, 8];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rand.Next(1, 10);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
    int[] mas1 = new int[8];
    for (int j = 0; j < mas.GetLength(1); j++)
{
    x = 0;    
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        if (mas[i, j] % 2 != 0)
        {
            x++;
        }
    }
    mas1[j] = x;
    Console.Write($"(Столбец:{j+1} Количество нечетных элементов:{mas1[j]}) ");
}
Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}