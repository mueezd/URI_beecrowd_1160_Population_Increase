using System;

namespace URI_beecrowd_1160_Population_Increase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PA, PB, T, n, i, p = 0, d, q = 0, e;
            float G1, G2;
            T = int.Parse(Console.ReadLine());
            for (i = 0; i < T; i++)
            {

                string[] inputValue = Console.ReadLine().Split();
                PA = int.Parse(inputValue[0]);
                PB = int.Parse(inputValue[1]);
                G1 = float.Parse(inputValue[2]);
                G2 = float.Parse(inputValue[3]);



                d = PA;
                e = PB;
                n = 0;
                while (p <= q)
                {
                    p = (int)(d + d * (G1 / 100));
                    q = (int)(e + e * (G2 / 100));
                    d = p;
                    e = q;
                    n++;
                    if (n > 100)
                    {
                        break;
                    }
                }
                if (n > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine("{0} anos.", n);
                }
                p = 0;
                q = 0;
            }
        }
    }
}
