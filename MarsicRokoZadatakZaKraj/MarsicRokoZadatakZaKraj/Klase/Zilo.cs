using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsicRokoZadatakZaKraj.Klase
{
    class Zilo
    {
        string sta;
        double maxZina;
        int brTaca;

        public Zilo (string sta, double maxZina, int brTaca)
        {
            this.sta = sta;
            this.maxZina = maxZina;
            this.brTaca = brTaca;
        }
        public string ispis()
        {
            return "Vrsta: " + sta + "\nMax brzina: " + maxZina.ToString() + "\nBroj kotaca: " + brTaca.ToString();
        }
        public Zilo() { }

    }
}
