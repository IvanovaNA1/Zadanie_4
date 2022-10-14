
int[] M = new int[100];
int sum = 0;
Random rnd = new Random();
for (int i = 0; i < M.Length; i++)
{
    M[i] = rnd.Next(-1000, 1000);
}
Console.WriteLine("Чётные: ");
for (int i = 0; i < M.Length; i++)
{
    if (M[i] % 2 == 0)
    {
        Console.Write(M[i] + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("Кратные 3: ");
for (int i = 0; i < M.Length; i++)
{
    if (M[i] % 3 == 1)
    {
        Console.Write(M[i] + ", ");
    }
}
Console.WriteLine();
for (int i = 0; i < M.Length; i++)
{
    if (M[i] < 0)
    {
        sum += M[i];
    }
}
Console.WriteLine("Сумма отрицательных чисел: " + sum);
