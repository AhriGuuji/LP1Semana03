using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            float[,] A = new float [2,2];
            float[] B = new float [2];

            A[0,0] = float.Parse(args[0]);
            A[0,1] = float.Parse(args[1]);
            A[1,0] = float.Parse(args[2]);
            A[1,1] = float.Parse(args[3]);

            B[0] = float.Parse(args[4]);
            B[1] = float.Parse(args[5]);

            for (int i = 0; i < 2; i++)
            {
                float result = 0;
                for (int j = 0; j < 2; j++)
                {
                    result += A[i,j]*B[j];
                }
                Console.WriteLine($"| {result,7:f2} |");
            }  
        }
    }
}