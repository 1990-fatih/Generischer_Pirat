using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, generischer Pirat!");
            Getraenk g1 = new Getraenk() { Name = "weißer Rum", Herkunft = "Karibik" };
            Getraenk g2 = new Getraenk() { Name = "brauner Rum", Herkunft = "Jamaika" };
            Getraenk g3 = new Getraenk() { Name = "Scumm", Herkunft = "Monkey Island" };

            Pirat<Getraenk> p = new Pirat<Getraenk>();

            Flasche<Getraenk> flascheRumWeiß = new Flasche<Getraenk>();
            Flasche<Getraenk> flascheRumBraun = new Flasche<Getraenk>();
            Flasche<Getraenk> flascheScumm = new Flasche<Getraenk>();

            flascheRumWeiß.Fuellen(g1);
            flascheRumBraun.Fuellen(g2);
            flascheScumm.Fuellen(g3);

            p.Fuellen(flascheRumWeiß);
        }
    }
}
