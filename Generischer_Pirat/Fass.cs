using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    internal class Fass<T> where T : class
    {
        private T getraenk;

        public void Aufnehmen(T getraenk2) 
        { 
            getraenk = getraenk2;
        }

        public void Leeren()
        {
            this.getraenk = null;
        }
    }
}
