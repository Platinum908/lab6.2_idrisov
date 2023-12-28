//Лабораторная 6.2 Средний 24

using ClassLibrary6._2;
int n =5;
int m =5;
double[,] mas = new double[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = (Class1.Array(i, j));
        Console.Write($"{Class1.Array(i,j):F2} ");
    }
    Console.WriteLine();
}
Class1.Vector(mas);
Console.WriteLine($"G = {Class1.Function(mas)}");