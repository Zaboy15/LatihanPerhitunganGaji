using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            float gaji = 3000000;
            float pendapatan,totalGaji;

            Console.WriteLine("Penghitungan Gaji");
            Console.Write("Masukkan Pendapatan Anda : ");
            pendapatan = float.Parse(Console.ReadLine());

            if (pendapatan > 10000000 && pendapatan < 50000000)
            {
                totalGaji = pendapatan * 9 / 100 + gaji;
                Console.WriteLine("Total Pendapatan anda adalah {0} dan total gaji anda {1}", pendapatan, totalGaji);
            }
            else if (pendapatan == 50000000)
            {
                totalGaji = pendapatan * 12 / 100 + gaji;
                Console.WriteLine("Total Pendapatan anda adalah {0} dan total gaji anda {1}", pendapatan, totalGaji);
            } else if(pendapatan > 50000000)
            {
                totalGaji = pendapatan * 15 / 100 + gaji;
                Console.WriteLine("Total Pendapatan anda adalah {0} dan total gaji anda {1}", pendapatan, totalGaji);
            } else if(pendapatan < 10000000)
            {
                totalGaji = pendapatan * 0 / 100 + gaji;
                Console.WriteLine("Total Pendapatan anda adalah {0} dan total gaji anda {1}", pendapatan, totalGaji);
            }

            Console.ReadLine();

        }
    }
}
