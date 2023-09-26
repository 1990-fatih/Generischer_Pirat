using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat_V2
{
    internal class Fass<T>
    {
        public List<Getraenk> Getraenke { get; set; } = new List<Getraenk>();
        public void Aufnehmen(T getraenk)
        {
            // code?
        }
        public void Leeren()
        {
            //code?
        }
    }
}
