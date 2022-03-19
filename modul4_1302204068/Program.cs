using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul4_1302204068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
        }
    }
}

class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T masukin01, T masukin02, T masukin03)
    {
        dynamic temp01 = masukin01;
        dynamic temp02 = masukin02;
        dynamic temp03 = masukin03;

        Console.WriteLine(temp01 + temp02 + temp03);

    }
}
