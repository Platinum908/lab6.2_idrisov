
namespace ClassLibrary6._2
{
    public class Class1
    {
        public static double Array(int i, int j)
        {
            return Math.Sqrt(i - j) * Math.Pow(Math.Pow(Math.Cos(i), 3) + (Math.Pow(Math.Cos(j), 3)), 3) - Math.Pow(-9, i + j) * Math.Log(Math.Exp(i + 9));
        }
        public static double Vector(double[,] mas)
        {
            for (int j =0; j < mas.GetLength(1); j++)
            {
                double min = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    if (i == 0) min = mas[j, i];
                    min = min > mas[j, i] && mas[j, i] != double.NaN ? mas[j,i] : min;
                }
                Console.WriteLine($"Вектор столбца {j+1}: {Math.Pow(min,2)}");
            }
            return 0;
        }
        public static double Function(double[,] mas)
        {
            double p = 1, s = 0;
            for(int k = 2; k < 3; k++)
            {
                for (int j = 6; j > k; j--)
                {
                    s += Math.Pow(Math.Abs(j - Math.Exp(1)), 4);
                }
                p *= 3 * s;
            }
            return Math.Log(Math.Abs(p), 5);
        }

    }
}