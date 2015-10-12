using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur_des
{
    public class Lancer
    {
        public DeGenerique De;
        public int nblancers;
        public int[] Lancers;
        public int resultat;
        
        public Lancer(DeGenerique d, int n)
        {
            De = d;
            nblancers = n;
            Lancers = new int[n];
            resultat = 0;
        }

        public void roll()
        {
            Random randy = new Random();
            for (int i = 0; i < nblancers; i++)
            {
                Lancers[i] = De.Valeurs[randy.Next(0,De.Face)];
                resultat += Lancers[i];
            }
        }
    }
}
