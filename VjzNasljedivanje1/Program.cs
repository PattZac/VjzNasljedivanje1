using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjzNasljedivanje1
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi;
        double brzinaOkoSunca;
        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOosi, double brzinaOsunca)
        {
            this.BrzinaOkoOsi = brzinaOosi;
            this.BrzinaOkoSunca = brzinaOsunca;
        }
        public override string ToString()
        {
            return " - Planet. \r\nBrzina Oko Osi " + this.BrzinaOkoOsi + " km/h. Brzina Oko Sunca "+this.BrzinaOkoSunca+" km/h.";
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOosi, double brzinaOsunca)
        {
            this.BrzinaOkoOsi = brzinaOosi;
            this.BrzinaOkoSunca = brzinaOsunca;
        }
        public override string ToString()
        {
            return " - Satelit. \r\nBrzina Oko Osi " + this.BrzinaOkoOsi + " km/h. Brzina Oko Sunca " + this.BrzinaOkoSunca + " km/h.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1676, 107000);
            Satelit Mjesec = new Satelit(16.7, 107000);
            Console.WriteLine("\r\nZemlja" + Zemlja.ToString());
            Console.WriteLine("\r\nMjesec" + Mjesec.ToString());
            Console.ReadKey();
        }
    }
}
