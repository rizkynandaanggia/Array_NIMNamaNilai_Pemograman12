using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumMinggu12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNim = { 2021, 2022, 2023 };
            string[] arrNama = { "Anggi", "Adiba", "Kevin" };
            int[] arrNilai = { 80, 87, 93 };

            Console.WriteLine("No.          Nim       Nama       Nilai");
            Console.WriteLine("=======================================");

            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine("{0}.           {1}      {2}       {3}", i + 1, arrNim[i], arrNama[i], arrNilai[i]);
            }
            Console.ReadKey();
        }
    }
}
