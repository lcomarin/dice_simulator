    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur_des
{
    public class Historique
    {
        public List<Lancer> histo;


        public Historique()
        {
            histo = new List<Lancer>();
        }
        public void maj(Lancer l)
        {
            histo.Add(l);
        }
    }
}
