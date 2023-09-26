using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generischer_Pirat
{
    internal class Pirat<T> where T : class
    {
        private string Name { get; set; }
        private bool IsTLeer {  get; set; }
        private List<T> flasche { get; set; }

        private T Fass { get; set; }
        public void Füllen(Flasche<T> flasche)
        {
            this.flasche = flasche;
            this.IsTLeer = false;
        }

        public void Leeren() 
        { 
            this.IsTLeer= true;
            Console.WriteLine("Private leer");
        }

        public bool IstLeer() 
        {
            return this.IsTLeer;
            
        }
    }
}
