using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    internal class Flasche<T> where T : class
    {
        private bool leer;
        private T getraenk;
        public bool IstLeer()
        {
            return leer;
        }
        public void Fuellen(T getraenk)
        {
            this.getraenk = getraenk;
            this.leer = false;
        }
        public T Leeren()
        {
            T lokal = this.getraenk;
            this.leer = true;
            this.getraenk = null;
            return lokal;
        }
    }
}
