using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat_V2
{
    internal class Flasche<T>
    {
        public T Inhalt { get; set; }
        public void Fuellen(T getraenk)
        {
            this.Inhalt = getraenk;
        }
        public T Leeren()
        {
            // Flasche tatsächlich leeren
            return Inhalt;
        }
        public bool IstLeer()
        {
            return true;
        }
    }
}
