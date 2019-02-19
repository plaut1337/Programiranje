using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");*/
            int brKot;
            bool leti = false, pliva = false, vozi = true, temp = true;
            string vrsta, oznaka, l, v, p, t;
            while(temp == true)
            { 
                Console.WriteLine("Broj kotaca?");
                brKot = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nLeti? y/n");
                l = Console.ReadLine();
                if (l == "y"){ leti = true; }
                else if (l == "Y") { leti = true; }
                else if (l == "n") { leti = false; }
                else if (l == "N") { leti = false; }
                Console.WriteLine("\nPliva? y/n");
                p = Console.ReadLine();
                if (p == "y") { pliva = true; }
                else if (p == "Y") { pliva = true; }
                else if (p == "n") { pliva = false; }
                else if (p == "N") { pliva = false; }
                Console.WriteLine("\nVozi? y/n");
                v = Console.ReadLine();
                if (v == "y") { vozi = true; }
                else if (v == "Y") { vozi = true; }
                else if (v == "n") { vozi = false; }
                else if (v == "N") { vozi = false; }
                Console.WriteLine("\nVrsta?");
                vrsta = Console.ReadLine();
                Console.WriteLine("\nOznaka?");
                oznaka = Console.ReadLine();
                Vozilo kamijon = new Vozilo(brKot, leti, pliva, vozi, vrsta, oznaka);

                /*Console.WriteLine("Vrsta: " + avijon.getVrsta() + "\nOznaka: " +
                avijon.getOznaka() + "\nLeti: " + avijon.getLeti() + "\nPlovi: "+ avijon.getPliva()
                + "\nVozi: " + avijon.getVozi() + "\nBroj kotača: "+avijon.getBrojKotaca() + "\n");*/
            
                Console.WriteLine(kamijon.ToString());

                Console.WriteLine("\nZelite li ponoviti upis? y/n");
                t = Console.ReadLine();
                if (t == "y") { temp = true; Console.WriteLine("\n"); }
                else if (t == "Y") { temp = true; Console.WriteLine("\n"); }
                else if (t == "n") { temp = false; Console.WriteLine("\n"); }
                else if (t == "N") { temp = false; Console.WriteLine("\n"); }
            }
            Console.ReadLine();
        }
    }

    
}
