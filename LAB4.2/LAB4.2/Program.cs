try
{
int x = 0;
Random rand = new Random();
int[,] mas = new int[7, 8];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rand.Next(1, 10);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] % 2 != 0)
        {
            x++;
        }
    }
}
Console.WriteLine("Количество нечетных элементов: "+x);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}