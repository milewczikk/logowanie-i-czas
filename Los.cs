using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Los
    {
        public static int Losowanie()
        {
            Random rnd = new Random();

            int poczatek = 9999;
            int koniec = 100000001;
            int wylos = rnd.Next(poczatek, koniec);
            return wylos;
        }
    }
}
