using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat_V2
{
    internal class Pirat<T>
    {
        public string Name { get; set; }
        public Fass<T> einFass { get; set; } = new Fass<T>();

        private List<T> Getraenke = new List<T>();
        public void Fuellen(Flasche<T> flasche)
        {
            //T inhalt = flasche.Leeren();
            //einFass.Aufnehmen(inhalt);
            Getraenke.Add(flasche.Leeren());
        }
        public string Leeren()
        {
            return "ein String";
        }
        public bool IstLeer()
        {
            return true;
        }
    }
}
