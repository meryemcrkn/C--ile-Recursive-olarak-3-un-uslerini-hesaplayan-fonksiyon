using System;

namespace özyinelemeli_metod
{
    class Program

    {

        static double j = 0, sonuc = 0;

        static double fak(int a)

        {

            if (j <= a)

            {

                sonuc = Math.Pow(3, j);

                j++;

                Console.Write("{0} ", sonuc);

                fak(a);

            }

            return sonuc;

        }

        static void Main(string[] args)

        {

            int b;

            Console.Write("3 sayısının sıfırıncı üssünden kaçıncı üssüne kadar yazılsın = ");

            b = int.Parse(Console.ReadLine());

            fak(b);

            Console.ReadKey();

        }

    }
}
