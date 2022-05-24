int[,] TwoD = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < TwoD.GetLength(0); i++)
{
    for (int j = 0; j < TwoD.GetLength(1); j++)
    {
        Console.Write("{0} ", TwoD[i, j]);
    }
    Console.WriteLine();
}

int sum = TwoD.Cast<int>().Sum();

Console.WriteLine(sum);