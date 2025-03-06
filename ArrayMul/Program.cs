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
            float[,] B = new float [2,1];
            
            int i = 0;
            int j = 0;

            for (int k = 0; k < 4; k++)
            {
                float eachArgs = float.Parse(args[k]);
                A[j,i] = eachArgs;
                i++;
                if (i == 2)
                {
                    i=0;
                    j=1;
                }
            }

            i = 0;
            j = 0;

            for (int k = 4; k < 6; k++)
            {
                float eachArgs = float.Parse(args[k]);
                B[j,i] = eachArgs;
                i++;
                if (i == 1)
                {
                    i=0;
                    j=1;
                }
            }

            foreach (float a in A)
            {
                Console.WriteLine(a);
            }
            foreach (float a in B)
            {
                Console.WriteLine(a);
            }
        }
    }
}
