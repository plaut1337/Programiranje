using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsicRokoZadatakZaKraj.Klase;

namespace MarsicRokoZadatakZaKraj
{
    class Program
    {
        static void Main(string[] args)
        {
            string sta;
            int brTaca;
            double maxZina;
            Console.WriteLine("Vrsta: ");
            sta = Console.ReadLine();
            Console.WriteLine("\nMax brzina: ");
            maxZina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBroj kotaca: ");
            brTaca = Convert.ToInt32(Console.ReadLine());
            Zilo cikl = new Zilo(sta, maxZina, brTaca);
            Zilo auto = new Zilo(sta, (maxZina*1.3), (brTaca*2));
            Console.WriteLine(cikl.ispis());
            Console.WriteLine(auto.ispis());
            Console.ReadKey();
        }
    }
}
